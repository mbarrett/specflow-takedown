using System.Configuration;
using api_acceptance_tests.Support;
using TechTalk.SpecFlow;

namespace api_acceptance_tests.Steps
{
    [Binding]
    public class SharedSteps : StepsBase
    {
        [When(@"I make a request")]
        public void WhenIMakeARequest()
        {
            var uri = ConfigurationManager.AppSettings["ApiUri"];
            var endpoint = Retrieve<string>("endpoint");

            var response = HttpClient.Get(uri + endpoint);

            Save("response", response);
        }     
    }
}
