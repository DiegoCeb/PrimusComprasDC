using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App.ContextoPrimusDb.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimusCompras.Models;

namespace PrimusCompras.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private IProductosRepository _productosRepository;
        //private readonly UserManager<IdentityUser> userManager;
        //private readonly SignInManager<IdentityUser> signInManager;

        public HomeController(IProductosRepository productosRepository)
        {
            _productosRepository = productosRepository;
            //this.userManager = userManager;
            //this.signInManager = signInManager;
        }

        //[AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
