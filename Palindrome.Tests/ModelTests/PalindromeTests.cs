using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

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
  }
}