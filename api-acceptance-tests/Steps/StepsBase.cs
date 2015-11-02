using TechTalk.SpecFlow;

namespace api_acceptance_tests.Steps
{
    public class StepsBase
    {
        protected void Save<T>(string name, T item)
        {
            ScenarioContext.Current[name] = item;
        }

        protected T Retrieve<T>(string name) where T : class
        {
            return ScenarioContext.Current[name] as T;
        }
    }
}
