using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Introduction.Controllers
{
    [RoutePrefix("Pravin")]
    public class HomeController : Controller
    {
        public string Index()
        {
            return "My First MVC Application";
        }
        public string Index1(int id)
        {
            return $"id Value received : {id}";
        }

        [Route("Index2/{id}/{rollnumber}")]
        public string Index2(int? id, int? rollnumber)
        {
            return $"index2 : id :{id} roll number : {rollnumber}";
        }
        [Route("default")]
        public string Default()
            {
            return $"<h1> Welcome o MVC5 </h2>" +
                $"<p> Learn All MVC Concept</p>";
            }
    }
}