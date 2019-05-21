using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShowppingStore.Models;

namespace ShowppingStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var category = new List<Category>
            {
                new Category  { Name = "Electronics"},
                new Category { Name = "Ferniture"},
                new Category { Name = "Accessories"}
            };
            return View(category);
        }
        public ActionResult Browser(string category)
        {
            //string massage = HttpUtility.HtmlEncode("showing details"+category);
            var categoryModel = new Category { Name = "Category "+ category };
            return View(categoryModel);
        }
        public ActionResult Details ( int id)
        {
            var item = new Item { Title = "item" + id };
            //string mssage = "store details " + Id;
            return View(item);
                }
    }
}