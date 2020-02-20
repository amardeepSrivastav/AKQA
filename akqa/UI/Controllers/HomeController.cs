using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Utility;
using System.Configuration;
using UI.Models.Person;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        IPersonService _personService;
        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult GetPersonResult(Person person)
        {
            if (ModelState.IsValid)
            {
                PersonViewModel personViewModel = _personService.getConvertedNumber(person);
                return Json(personViewModel,JsonRequestBehavior.AllowGet);
            }
            else { 
                return RedirectToAction("Index");
            }
        }
    }
}