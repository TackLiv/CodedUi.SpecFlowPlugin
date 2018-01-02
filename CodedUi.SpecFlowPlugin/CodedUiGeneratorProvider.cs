namespace TackLiv.CodedUI.SpecFlowPlugin
{
    using System.CodeDom;

    using TechTalk.SpecFlow.Generator;
    using TechTalk.SpecFlow.Generator.UnitTestProvider;
    using TechTalk.SpecFlow.Utils;

    public class CodedUiGeneratorProvider : MsTest2010GeneratorProvider
    {
        private const string CodedUiTestAttributeName = "Microsoft.VisualStudio.TestTools.UITesting.CodedUITestAttribute";
        private const string UnitTestAttributeName = "Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute";

        public CodedUiGeneratorProvider(CodeDomHelper codeDomHelper)
            : base(codeDomHelper)
        {
        }

        public override void SetTestClass(
            TestClassGenerationContext generationContext,
            string featureTitle,
            string featureDescription)
        {
            base.SetTestClass(generationContext, featureTitle, featureDescription);

            foreach (CodeAttributeDeclaration customAttribute in generationContext.TestClass.CustomAttributes)
            {
                if (customAttribute.Name == UnitTestAttributeName)
                {
                    generationContext.TestClass.CustomAttributes.Remove(customAttribute);
                    break;
                }
            }

            generationContext.TestClass.CustomAttributes.Add(
                new CodeAttributeDeclaration(
                    new CodeTypeReference(CodedUiTestAttributeName)));
        }
    }
}