using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniProject.Models;
using MiniProject.ViewModels;

//Controller for general pages like Homepage, about and contact

namespace MiniProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            if (User.IsInRole("Admin"))
            {
                var usersWithRoles = (from user in _context.Users
                    select new
                    {
                        UserId = user.Id,
                        Username = user.UserName,
                        Email = user.Email,
                        Gender = user.Gender,
                        FullName = user.FullName,
                        DOB = user.DOB,
                        RoleNames = (from userRole in user.Roles
                            join role in _context.Roles on userRole.RoleId
                                equals role.Id
                            select role.Name).ToList()
                    }).ToList().Select(p => new UsersViewModel()

                {
                    UserId = p.UserId,
                    Username = p.Username,
                    Email = p.Email,
                    Gender = p.Gender,
                    FullName = p.FullName,
                    DOB = p.DOB,
                        Role = string.Join(",", p.RoleNames)
                });

                return View("UserListing", usersWithRoles);
            }
             
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
