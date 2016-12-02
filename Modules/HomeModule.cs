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

    }
  }
}
