using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject.ViewModels
{
    public class UsersViewModel
    {
       
            public string UserId { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }

            public string FullName { get; set; }
            public DateTime DOB { get; set; }
            public string Gender { get; set; }
            
    }
}