using MVC5Introduction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Introduction.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View("~/merewaleviews/ViewPage1.cshtml");
        }
        public ActionResult Index1()
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){Id =1, Name= " Caterogy 1",Rating=5 },
                new Category(){Id =2, Name= " Caterogy 2",Rating=4 },
                new Category(){Id =3, Name= " Caterogy 3",Rating=5 },
                new Category(){Id =4, Name= " Caterogy 4",Rating=3 },
                new Category(){Id =5, Name= " Caterogy 5",Rating=5 }

            };

            return View("Index1", categories);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateCategory()
        {
            Category category = new Category() { Id = 1, Name = "Pravin", Rating = 5 };

            return View(category);
        }
    }
}