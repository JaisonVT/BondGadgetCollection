﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BondGadgetCollection.Controllers
{
    public class GadgetController : Controller
    {
        // GET: Gadget
        public ActionResult Index()
        {
            return View();
        }
    }
}