using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolProject.Models;

namespace SchoolProject.Controllers
{
    public class HomeController : ApplicationController
    {
        public ActionResult Index()=> View();

        public ActionResult About() => View();

        public ActionResult Contact()=> View();

        
    }
}