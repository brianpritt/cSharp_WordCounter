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
      string[] arrayUserString = this.UserString.Split();// splits user input into array of words
      string checkWord = this.UserCheck.ToLower();
      List<string> punctList = new List<string>() {"!","@","#","$","%","^","&","*",",",".",".","`","=","+","<",">","_"};
      int loopVar = 0;
      foreach(string word in arrayUserString)//loops through array and compares each word to check word
      {
        foreach(string punct in punctList){
          if (word.Contains(punct))
          {
            arrayUserString[loopVar] = word.Replace(punct,"");
          }
        }
        if (arrayUserString[loopVar].ToLower() == checkWord)
        {
          this.Repeats +=1;//if there is a match, this counter will go up
        }
        loopVar ++;
      }
    }
  }
}
