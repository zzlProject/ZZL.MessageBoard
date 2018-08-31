﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZZL.MessageBoard.Service.IService;
using ZZL.MessageBoard.Service.Service;

namespace ZZL.MessageBoard.Web.Controllers
{
    public class HomeController : Controller
    {
        ICustomerService customerService = new CustomerService();
        public ActionResult Index()
        {
            var list = customerService.GetList(null);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}