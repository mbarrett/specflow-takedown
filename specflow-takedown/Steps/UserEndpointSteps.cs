using EasyHttp.Http;
using Shouldly;
using specflow_takedown.Models;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace specflow_takedown.Steps
{
    [Binding]
    public class UserEndpointSteps : StepsBase
    {
        private IList<User> _users = new List<User>();

        [Given(@"I am requesting user metadata")]
        public void GivenIAmRequestingUserMetadata()
        {
            Save("uri", "http://jsonplaceholder.typicode.com/users");
        }

        [Then(@"the response should include (.*) users")]
        public void ThenTheResponseShouldIncludePhotos(int count)
        {
            var response = Retrieve<HttpResponse>("response");
            _users = response.StaticBody<IList<User>>();
            _users.Count.ShouldBe(count);
        }

        [Then(@"each user should include the field ""(.*)""")]
        public void EachUserShouldIncludeTheField(string fieldName)
        {
            _users.ShouldNotBeEmpty();

            foreach (var user in _users)
            {
                var outcome = user.GetType().GetProperty(fieldName);
                outcome.ShouldNotBeNull();
            }
        }
    }
}
