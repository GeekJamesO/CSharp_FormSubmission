using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.errors = new string[0];
            return View();
        }

        [HttpPost]
        [Route("process")]
        public IActionResult process(string FirstName, string LastName, int Age,  string Email, string Password)
        {
            Person p = new Person();
            p.FirstName = FirstName;
            p.LastName = LastName;
            p.Age = Age;
            p.Email = Email;
            p.Password = Password;

            TryValidateModel(p);
            if (ModelState.ErrorCount > 0) 
            {
				ViewBag.errors = ModelState.Values;
				return View("Index");
            }    
            else
            {
				return Redirect("success");
            }
        }
		[HttpGet]
		[Route("success")]
		public IActionResult success()
		{
			return View();
		}

	}
}
