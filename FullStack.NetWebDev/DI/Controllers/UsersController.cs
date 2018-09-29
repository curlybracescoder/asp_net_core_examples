using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DI.Models;
using DI.Repositories;

namespace DI.Controllers
{
    public class UsersController : Controller
    {
        private IUserRepository userRepository;

        public UsersController(IUserRepository repository)
        {
            this.userRepository = repository;
        }

        [HttpGet]
        [Route("[controller]")]
        public IActionResult Get()
        {
            return Json(userRepository.GetAll().Select(x => x.Name).ToArray());
        }

        [HttpGet]
        [Route("[controller]/{name}")]
        public IActionResult Get(string name)
        {
            return Json(userRepository.GetByName(name));
        }
    }
}