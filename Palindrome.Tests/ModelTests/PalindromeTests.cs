using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;
using System;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void TestWordConstructor_CreateInstanceOfTestWord_TestWord()
    {
      // Arrange
      string testWord = "test";
      TestWord newTestWord = new TestWord(testWord);
      // Assert
      Assert.AreEqual(typeof(TestWord), newTestWord.GetType());
    }

    
    // [TestMethod]
    // public void IsPalindrome_MakeWordLowercase_String()
    // {
    //   // Arrange
    //   string wordLowercase = "test";
    //   TestWord testWord = new TestWord("TEST");
    //   // Act
    //   string testWordLowercase = testWord.IsPalindrome();
    //   // Assert
    //   Assert.AreEqual(testWordLowercase, wordLowercase);
    // }
    
    // [TestMethod]
    // public void  IsPalindrome_ConvertWordToCharacterArray_CharArray()
    // {
    //     // Arrange
    //     char[] charArray =  "test".ToCharArray();
    //     TestWord testWord = new TestWord("TEST");
    //     // Act
    //     char[] testCharacterArray = testWord.IsPalindrome();
    //     // Assert
    //     CollectionAssert.AreEqual(testCharacterArray, charArray);

    // }

    [TestMethod]

    public void IsPalindrome_ReverseCharacterArray_CharArray()
    {
        //Arrange
        char[] charArray = "tset".ToCharArray();
        TestWord testWord = new TestWord("test");
        //Act
        char[] testReverseArray = testWord.IsPalindrome();
        //Assert
        CollectionAssert.AreEqual(testReverseArray, charArray);
    }
  }
}