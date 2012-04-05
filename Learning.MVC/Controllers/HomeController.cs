using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning.MVC.Controllers
{
  public class HomeController : Controller
  {
    //
    // GET: /Home/

    public ActionResult Index()
    {
      return View();
    }

    [ValidateInput(false)]
    public ActionResult Lesson1(string content)
    {
      if(string.IsNullOrEmpty(content))
      {
        content = 
@"<html>
<body>
<h1>My First Heading</h1>
<p>My first paragraph.</p>
</body>
</html>";
      }
      ViewBag.Content = content;
      return View();
    }

    public ActionResult Lesson2()
    {
      return View();
    }

    public ActionResult Lesson3()
    {
      return View();
    }

  }
}
