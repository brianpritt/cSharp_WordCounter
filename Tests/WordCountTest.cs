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
      newCounter.CountRepeats();
      //Assert
      Assert.Equal(true, newCounter.Repeats == 1);
    }
    [Fact]
    public void IsMatch_StringMatch_true()
    {
      //Arrange
      string word = "this is nice";
      string checkWord = "this";
      RepeatCounter newCounter = new RepeatCounter(word, checkWord);
      //Act
      newCounter.CountRepeats();
      //Assert
      Assert.Equal(true, newCounter.Repeats == 1);
    }
    [Fact]
    public void IsMatch_StringMatchCase_true()
    {
      //Arrange
      string word = "THIS is nice";
      string checkWord = "this";
      RepeatCounter newCounter = new RepeatCounter(word, checkWord);
      //Act
      newCounter.CountRepeats();
      //Assert
      Assert.Equal(true, newCounter.Repeats == 1);
    }
    [Fact]
    public void IsMatch_StringMatchPunctuation_true()
    {
      //Arrange
      string word = "This, is nice";
      string checkWord = "this";
      RepeatCounter newCounter = new RepeatCounter(word, checkWord);
      //Act
      newCounter.CountRepeats();
      //Assert
      Assert.Equal(true, newCounter.Repeats == 1);
    }
    [Fact]
    public void IsMatch_StringMatchMultiples_true()
    {
      //Arrange
      string word = "this here, this is nice";
      string checkWord = "this";
      RepeatCounter newCounter = new RepeatCounter(word, checkWord);
      //Act
      newCounter.CountRepeats();
      //Assert
      Assert.Equal(true, newCounter.Repeats == 2);
    }
  }
}
