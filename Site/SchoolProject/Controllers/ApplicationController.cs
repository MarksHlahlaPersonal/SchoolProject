using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolProject.Models;
using System.Web.Mvc;

namespace SchoolProject.Controllers
{
    public class ApplicationController : Controller
    {
        public CMS_SchoolEdEntities1 db = new CMS_SchoolEdEntities1();
        public ApplicationController() {
            if (ViewBag.Menu == null || ViewBag.RefreshMenu != null)
            {
                ViewBag.Menu = db.CMS_Menu.OrderBy(a => a.MenuOrder);
                ViewBag.RefreshMenu = null;
            }
        }
    }
}