using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day26_MVCValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day26_MVCValidation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserForm()
        {
            return View(new User());
        }

        public IActionResult DisplayUser(User user)
        {
            if(ModelState.IsValid) //checks if the model object is valid(meets data annotation requirements)
            { 
            return View();
            }
            else
            {
                //the model object of type User did not match the requirements we made in our user class
                return View("UserForm", user);
            }
        }
    }
}