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
        char[] arrStr = newTranslator.ArrayMaker("Bear");
        int strLength = arrStr.Length;
        Console.WriteLine(arrStr);
        Console.WriteLine(arrStr.Length);
        Assert.AreEqual(4, arrStr.Length);
      }
    }
}