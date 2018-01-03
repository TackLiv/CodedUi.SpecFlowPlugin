namespace SpecFlow.CodedUI.MsTest.Examples
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TackLiv.CodedUi.Fluent.Extensions;

    using TechTalk.SpecFlow;

    [Binding]
    public sealed class SpecFlowHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ValidateExtension.SetAssertor(Assert.IsTrue);
        }
    }
}