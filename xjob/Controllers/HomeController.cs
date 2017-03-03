﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using xjob.Data;
using Microsoft.AspNetCore.Identity;
using xjob.Models;

namespace xjob.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _environment;
        private UserManager<ApplicationUser> _userManager;

        public HomeController(IHostingEnvironment environment, UserManager<ApplicationUser> userManager)
        {
            _environment = environment;
            _userManager = userManager;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult ProfilePic()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userID = _userManager.GetUserId(User);
                if (userID == null)
                {
                   
                }
                var u = _userManager.Users.Where(x => x.Id == userID).SingleOrDefault();
                return File(u.ProfilePic, "image/png");
            }
            string fileName = Path.Combine(_environment.WebRootPath, "images/placeholderpic.png");
            byte[] imageData = null;
            FileInfo fileInfo = new FileInfo(fileName);
            long imageLength = fileInfo.Length;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)imageLength);
            return File(imageData, "image/png");
        }
    }
}
