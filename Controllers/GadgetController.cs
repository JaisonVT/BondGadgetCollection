using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BondGadgetCollection.Data;
using BondGadgetCollection.Models;

namespace BondGadgetCollection.Controllers
{
    public class GadgetController : Controller
    {
        // GET: Gadget

        public ActionResult Index()
        {
            List<GadgetModel> gadgets = new List<GadgetModel>();

            GadgetDAO gadget = new GadgetDAO();

            gadgets = gadget.FetchAll();
            
            return View("Index",gadgets);
        }
        
        public ActionResult Details(int id)
        {
            GadgetDAO gadgetDAO=new GadgetDAO();

            GadgetModel gadget1=gadgetDAO.FetchOne(id);
            
            return View("SingleDetails",gadget1);
        }
    }
}