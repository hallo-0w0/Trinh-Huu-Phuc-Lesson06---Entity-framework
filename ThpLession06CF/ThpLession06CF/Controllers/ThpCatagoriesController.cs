using System;
using System.Linq;
using System.Web.Mvc;
using ThpLession06CF.Models;

namespace ThpLession06CF.Controllers
{
    public class ThpCatagoriesController : Controller
    {
        private static ThpBookStore thpDb;
        public ThpCatagoriesController()
        {
            thpDb=new ThpBookStore();
        }
        // GET: ThpCatagories
        public ActionResult ThpIndex()
        {

            var thpCatagories = thpDb.ThpCategories.ToList();
            return View(thpCatagories);
        }

        // GET: ThpCatagories/ThpCreate
        public ActionResult ThpCreate()
        {
            var thpCategory = new ThpCategory();
            return View(thpCategory);
        }
        [HttpPost]
        public ActionResult ThpCreate(ThpCategory thpCategory)
        {
            thpDb.ThpCategories.Add(thpCategory);
            thpDb.SaveChanges();
            return RedirectToAction("ThpIndex");
        }
    }
}
