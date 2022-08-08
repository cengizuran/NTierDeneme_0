using NTierDeneme_0.ViewModels;
using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTierDeneme_0.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository _cRep;

        public CategoryController()
        {
            _cRep = new CategoryRepository();
        }

        public ActionResult ListCategories()
        {

            CategoryVM cvm = new CategoryVM
            {
                Categories = _cRep.GetActive()
            };
            

            return View(cvm);
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            _cRep.Add(category);
            _cRep.Save();

            return RedirectToAction("ListCategories");
        }

        public ActionResult UpdateCategory(int id)
        {
            CategoryVM cvm = new CategoryVM
            {
                Category = _cRep.Find(id)
            };
            return View(cvm);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            Category guncellenecek = _cRep.Find(category.ID);
            guncellenecek.CategoryName = category.CategoryName;
            guncellenecek.Description = category.Description;
            _cRep.Save();

            return RedirectToAction("ListCategories");
        }

        public ActionResult DeleteCategory(int id)
        {
            _cRep.Delete(_cRep.Find(id));
            _cRep.Save();

            return RedirectToAction("ListCategories");
        }
    }
}