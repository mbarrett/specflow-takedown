using TechTalk.SpecFlow;

namespace specflow_takedown.Support
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
