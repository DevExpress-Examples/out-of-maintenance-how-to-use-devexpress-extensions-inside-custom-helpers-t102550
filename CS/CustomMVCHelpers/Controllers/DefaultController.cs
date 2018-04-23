using MVCxGridViewDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomMVCHelpers.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GridViewPartial(){
            var model = MyModel.GetModelList();
            return PartialView(model);
        }

    }
}
