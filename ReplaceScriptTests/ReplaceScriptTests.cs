using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReplaceScript;
using System;

namespace ReplaceScriptTests
{
    [TestClass]
    public class ReplaceScriptTests
    {
        [TestMethod]
        public void Replace_With()
        {
            string expected = "nello";

            Script replaceScript = Script.Create().FromString("replace h with n\n").Build();
            string result = replaceScript.Execute("hello");

            

            Assert.AreEqual(expected, result);
        }
    }
}
