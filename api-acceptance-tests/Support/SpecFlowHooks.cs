using System;
using System.Configuration;
using System.Net;
using TechTalk.SpecFlow;

namespace api_acceptance_tests.Support
{
    [Binding]
    public class SpecFlowHooks
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            WarmUpApi();
        }

        private static void WarmUpApi()
        {
            var uri = ConfigurationManager.AppSettings["ApiUri"];
            var response = HttpClient.Get(uri);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(string.Format("Request to {0} did not return OK", uri));
            }

            Console.WriteLine("Request to {0} returned OK", uri);
        }
    }
}
