using Xunit;
using System;
using System.Collections.Generic;
using WordCount.Objects;

namespace  WordCount
{
  public class WordCountTest
  {
    [Fact]
    public void IsMatch_OneWord_true()
    {
      //Arrange
      string word = "this";
      string checkWord = "this";
      RepeatCounter newCounter = new RepeatCounter(word, checkWord);
      //Act
      int theTest = newCounter.CountRepeats();
      //Assert
      Assert.Equal(true, theTest == 1);
    }
    [Fact]
    public void IsMatch_StringMatch_true()
    {
      //Arrange
      string word = "this is nice";
      string checkWord = "this";
      RepeatCounter newCounter = new RepeatCounter(word, checkWord);
      //Act
      int theTest = newCounter.CountRepeats();
      //Assert
      Assert.Equal(true, theTest == 1);
    }
  }
}
