using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator.Models;

namespace Translator.Tests 
{
    [TestClass]
    public class TranslatorTests
    {
      [TestMethod]
      public void WordTurningIntoArray_True()
      {
        LeetspeakTranslator newTranslator = new LeetspeakTranslator("Bear");
        string arrStr = newTranslator.ArrayMaker("Bear");
        int strLength = arrStr.Length;
        Assert.AreEqual(4, arrStr.Length);
      }

      [TestMethod]
      public void eReplacedWith3_True()
      {
        LeetspeakTranslator newTranslator = new LeetspeakTranslator("Bear");
        string arrStr = newTranslator.ArrayMaker("Bear");
        Assert.AreEqual("B3ar", arrStr);
      }
    }
}