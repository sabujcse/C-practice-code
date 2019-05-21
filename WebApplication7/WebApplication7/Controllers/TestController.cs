using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            FirstEntities firstEntities = new FirstEntities();
            List<Example> examples = firstEntities.Examples.ToList();
            ExampleViews exampleViews = new ExampleViews();
            List<ExampleViews> views = examples.Select(x => new ExampleViews
            {
                Id = x.Id,
                First_Name = x.First_Name,
                Last_Name = x.Last_Name,
                Address = x.Address,
                Department = x.Department
            }).ToList();
            //Example example = firstEntities.Examples.SingleOrDefault(x => x.Id == 1);
            //ExampleViews views = new ExampleViews();
            //views.Id = example.Id;
            //views.First_Name = example.First_Name;
            //views.Last_Name = example.Last_Name;
            //views.Address = example.Address;
            //views.Department = example.Department;
            //AnotherExample example2 = new AnotherExample();
            //if(views.Department == "cse")
            //{
            //    views.Color = "green";
            //} 
            return View(views);
        }
    }
}