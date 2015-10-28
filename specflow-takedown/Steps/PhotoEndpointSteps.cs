using EasyHttp.Http;
using Shouldly;
using specflow_takedown.Models;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace specflow_takedown.Steps
{
    [Binding]
    public class PhotoEndpointSteps : StepsBase
    {
        private IList<Photo> _photos = new List<Photo>();
        
        [Given(@"I am requesting photo metadata")]
        public void GivenIAmRequestingPhotoMetadata()
        {
            Save("uri", "http://jsonplaceholder.typicode.com/photos");            
        }

        [Then(@"the response should include (.*) photos")]
        public void ThenTheResponseShouldIncludePhotos(int count)
        {
            var response = Retrieve<HttpResponse>("response");
            _photos = response.StaticBody<IList<Photo>>();
            _photos.Count.ShouldBe(count);
        }
        
        [Then(@"each photo should include the field ""(.*)""")]
        public void EachPhotoShouldIncludeTheField(string fieldName)
        {
            _photos.ShouldNotBeEmpty();

            foreach(var photo in _photos)
            {
                var outcome = photo.GetType().GetProperty(fieldName);
                outcome.ShouldNotBeNull();
            }
        }
    }
}
