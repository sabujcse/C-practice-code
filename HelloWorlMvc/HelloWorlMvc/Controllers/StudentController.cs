using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorlMvc.Models;
using HelloWorlMvc.BLL;

namespace HelloWorlMvc.Controllers
{
    public class StudentController : Controller
    {
        
        CustomerManager Manager = new CustomerManager();
        [HttpGet]
   
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                if (student.Name != null)
                {
                    student.SubDistrictId = 2;
                    var add = Manager.Save(student);
                    if (add)
                    {
                        ViewBag.SMs = "Successfully Added";
                    }
                    else
                    {
                        ViewBag.SMs = "Successfully Added";
                    }
                }
            }catch(Exception e)
            {
                ViewBag.FMs = e.Message;
            }
            return View();
        }
        public ActionResult Search()
        {
            var student = new Student();
            var DataList = Manager.Search(student);

            return View(DataList);
        }
        [HttpPost]
        public ActionResult Search(Student student)
        {
            var DataList = Manager.Search(student);
            return View(DataList);
        }
        public ActionResult Edit(int id)
        {
            Student student = Manager.GetById(id);
            student.SubdistrictLookUp = GetSubDistrictSelectItem();
            return View(student);
        }
        [HttpPost]

        public ActionResult Edit(Student student)
        {
            var update = Manager.Update(student);
            if (update)
            {
                return RedirectToAction("Search");
            }
            ViewBag.Fmsg = "Faild To Update";
            return View(student);            
        }
        public List<Subdistrict> Subdistricts()
        {
            var subdistrictList = new List<Subdistrict>
            {
                new Subdistrict{Id=1,Name="Monirampur"},
                new Subdistrict{Id=2,Name="Tala"},
                new Subdistrict{Id=3,Name="Sarsha"},

            };
            return subdistrictList;
        }
        public List<SelectListItem> GetSubDistrictSelectItem()
        {
            var dataList = Subdistricts();
            var subDistrictListItem = new List<SelectListItem>();
            subDistrictListItem.Add(DefaltselectItem());
            if(dataList != null && dataList.Count > 0)
            {
                foreach(var subDistrict in dataList)
                {
                    var selectedItem = new SelectListItem();
                    selectedItem.Text = subDistrict.Name;
                    selectedItem.Value = subDistrict.Id.ToString();
                    subDistrictListItem.Add(selectedItem);
                }
            }
            return subDistrictListItem;
        }
        public SelectListItem DefaltselectItem()
        {
            var selectedItem = new SelectListItem();
            selectedItem.Text = "----Select----";
            selectedItem.Value = "";
            return selectedItem;
        }

    }
}