using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceControl;
using System.Linq;
namespace WindowsAddonsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFunction()
        {
            RegexForCSharp regex = new RegexForCSharp();
            var found=regex.FindDefinedFunctions(" void TestMethod1()");
            Assert.AreEqual(1, found.Count);
            Assert.AreEqual("TestMethod1", found[0]);
        }
        
        [TestMethod]
        public void TestVariable()
        {
            RegexForCSharp regex = new RegexForCSharp();
            var found = regex.FindVariables("Files.ForEach(file =>            {                found.AddRange(func(File.ReadAllText(file)));            }); ");
            Assert.AreEqual(1, found.Count);
            Assert.AreEqual("file", found[0]);
        }
        [TestMethod]
        public void TestFunction2()
        {
            RegexForCSharp regex = new RegexForCSharp();
            var found = regex.FindDefinedFunctions("public void Build(IBuilder builder)");
            Assert.AreEqual(1, found.Count);
            Assert.AreEqual("Build", found[0]);
        }
        [TestMethod]
        public void TestFunction3()
        {
            RegexForCSharp regex = new RegexForCSharp();
            var found = regex.FindDefinedFunctions("                found.Add(varname);");
            Assert.AreEqual(0, found.Count);
        }
        [TestMethod]
        public void TestFunction4()
        {
            RegexForCSharp regex = new RegexForCSharp();
            var found = regex.FindDefinedFunctions("CSharpProjectInformation cSharpProjectInformation = new CSharpProjectInformation();");
            Assert.AreEqual(0, found.Count);
        }

        [TestMethod]
        public void TestVariableSo()
        {
            CSharpProjectInformation cSharpProjectInformation = new CSharpProjectInformation();
           Assert.IsTrue( cSharpProjectInformation.DefinedFunctions.Contains("Build"));
            
        }
    }
}
