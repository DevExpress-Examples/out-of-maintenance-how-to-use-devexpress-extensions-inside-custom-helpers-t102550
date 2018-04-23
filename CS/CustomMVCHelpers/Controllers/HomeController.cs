using MVCxGridViewDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CustomMVCHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GridViewPartial()
        {
            var model = MyModel.GetModelList();
            return PartialView(model);
        }
    }
}
