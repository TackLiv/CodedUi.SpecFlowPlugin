namespace TackLiv.CodedUI.SpecFlowPlugin
{
    using TechTalk.SpecFlow.Generator.Plugins;
    using TechTalk.SpecFlow.Generator.UnitTestProvider;
    using TechTalk.SpecFlow.UnitTestProvider;

    public class CodedUiGeneratorPlugin : IGeneratorPlugin
    {
        public void Initialize(
            GeneratorPluginEvents generatorPluginEvents,
            GeneratorPluginParameters generatorPluginParameters)
        {
            generatorPluginEvents.CustomizeDependencies += this.GeneratorPluginEvents_CustomizeDependencies;
        }

        private void GeneratorPluginEvents_CustomizeDependencies(object sender, CustomizeDependenciesEventArgs e)
        {
            e.ObjectContainer.RegisterTypeAs<CodedUiGeneratorProvider, IUnitTestGeneratorProvider>();
            e.ObjectContainer.RegisterTypeAs<MsTest2010RuntimeProvider, IUnitTestRuntimeProvider>();
        }
    }
}