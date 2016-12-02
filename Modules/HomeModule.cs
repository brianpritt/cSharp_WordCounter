using Nancy;
using System.Collections.Generic;
using System;
using WordCount.Objects;

namespace WordCount
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        RepeatCounter newCounter = new RepeatCounter(Request.Form["string"], Request.Form["word"]);
        newCounter.CountRepeats();
        return View["results.cshtml", newCounter];
      };

    }
  }
}
