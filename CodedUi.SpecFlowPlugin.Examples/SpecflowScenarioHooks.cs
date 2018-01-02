namespace SpecFlow.CodedUI.MsTest.Examples
{
    using System.Diagnostics;

    using Microsoft.VisualStudio.TestTools.UITesting;

    using TechTalk.SpecFlow;

    /// <summary>
    ///  For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
    /// </summary>
    [Binding]
    public sealed class SpecflowScenarioHooks
    {
        private static ApplicationUnderTest app;

        [AfterScenario]
        public void AfterScenario()
        {
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
           
        }
    }
}