// ------------------------------------------------------------------------------
//
//   SpecFlow NUnit Runner AddIn 
// 
//   This AddIn ensures the [AfterTestRun] hook to be fired when the tests are
//   executed with *nunit-console.exe* or *nunit-console-x86.exe*.  
//   For executing the tests with other runner, this code is not necessary.
//
//   See also: https://github.com/techtalk/SpecFlow/wiki/Unit-test-providers
//   Copyright © SpecFlow 2012, http://www.specflow.org
//
// ------------------------------------------------------------------------------
namespace TechTalk.SpecFlow
{
    internal interface IExtensionPoint
    {
        void Install(SpecFlowNUnitExtension specFlowNUnitExtension);
    }
}