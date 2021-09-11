using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BondGadgetCollection.Models;

namespace BondGadgetCollection.Controllers
{
    public class GadgetController : Controller
    {
        // GET: Gadget
        public ActionResult Index()
        {
            List<GadgetModel> gadgets = new List<GadgetModel>();
            gadgets.Add(new GadgetModel(1, "Gun", "A secret gun", "Moonbraker", "name"));
            gadgets.Add(new GadgetModel(2, "Gunn", "A secret ", "Moonbrak", "Actor"));
            gadgets.Add(new GadgetModel(3, "Gunnn", "A sec", "Moonbr", "Actorame"));
            gadgets.Add(new GadgetModel(4, "Gunnnn", "A ", "Moon", "Act name"));
            
            return View("Index",gadgets);
        }
    }
}