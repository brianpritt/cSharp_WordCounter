using System;
using System.Collections.Generic;

namespace WordCount.Objects
{
  public class RepeatCounter
  {
    public string UserString {get; set;}
    public string UserCheck {get; set;}
    public int Repeats {get; set;}

    public RepeatCounter(string userInputString, string userInputCheck)
    {
      this.UserString = userInputString;
      this.UserCheck = userInputCheck;
      this.Repeats = 0;
    }
    public void CountRepeats()
    {
      string[] arrayUserString = this.UserString.Split();
      string checkWord = this.UserCheck.ToLower();
      int loopVar = 0;
      foreach(string word in arrayUserString)
      {
        if (arrayUserString[loopVar].ToLower() == checkWord)
        {
          this.Repeats +=1;
        }
        loopVar ++;
    }
    }
  }
}
