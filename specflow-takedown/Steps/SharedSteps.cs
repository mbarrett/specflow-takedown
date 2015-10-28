using specflow_takedown.Support;
using TechTalk.SpecFlow;

namespace specflow_takedown.Steps
{
    [Binding]
    public class SharedSteps : StepsBase
    {
        [When(@"I make a request")]
        public void WhenIMakeARequest()
        {
            var uri = Retrieve<string>("uri");
            var response = HttpClient.Get(uri);

            Save("response", response);
        }     
    }
}
