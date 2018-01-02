using System.Reflection;
using System.Runtime.InteropServices;

using TackLiv.CodedUI.SpecFlowPlugin;

using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Plugins;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SpecFlow.CodedUI")]
[assembly: AssemblyDescription("Customized Specflow test generator privdor for Coded UI with MsTest")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SpecFlow.CodedUI")]
[assembly: AssemblyCopyright("Copyright ©  2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("be389a35-3de5-431d-84cb-87bf1e12e182")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: GeneratorPlugin(typeof(CodedUiGeneratorPlugin))]
