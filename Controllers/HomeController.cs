﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcLaundry.Models;
using Microsoft.AspNetCore.Authorization; 
using MvcLaundry.Data; 
using Microsoft.EntityFrameworkCore;

namespace MvcLaundry.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcLaundryContext _context;

        public HomeController(ILogger<HomeController> logger, MvcLaundryContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="User")]  
        public async Task<ActionResult> Users()  
        {  
            return View(await _context.Users.ToListAsync()); 
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

        public IActionResult OrderLaundry(){
            return View();
        }

        public IActionResult RiwayatTransaksi(){
            return View();
        }

        public IActionResult ContactUs(){
            return View();
        }
    }
}
