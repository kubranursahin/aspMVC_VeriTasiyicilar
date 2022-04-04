using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspMVC2.Models
{
    public class UserRoleViewModel
    {
        public List<Models.User> Users { get; set; }
        public List<Models.Role> Roles { get; set; }
    }
}