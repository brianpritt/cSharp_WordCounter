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
    public int CountRepeats()
    {
      if (this.UserString == this.UserCheck)
      {
        this.Repeats +=1;
      }
      int returnValue = this.Repeats;
      
      return returnValue;
    }
  }
}
