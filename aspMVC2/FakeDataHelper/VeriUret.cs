using aspMVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspMVC2.FakeDataHelper
{
    public class VeriUret
    {
        public static List<User> CreateUserList()
        {
            List<User> users = new List<User>();
            users.Add(new User { Id = 5, RoleId = 1, Address = "Ankara", Email = "kns@gmail.com", FullName = "Kübranur Şahin"});
            users.Add(new User { Id=10, RoleId = 2, Address = "İstanbul", Email = "fy@gmail.com", FullName="Furkan Yalçınkaya"});
            users.Add(new User { Id = 15, RoleId = 2, Address = "Muğla", Email ="gy@gmail.com", FullName ="Güneş Yalçınkaya"});
            users.Add(new User { Id=20, RoleId = 2, Address = "Malatya", Email = "bk@gmail.com", FullName="Beril Kaya"});
            users.Add(new User { Id=25, RoleId = 2, Address="Mersin", Email="ic@gmail.com", FullName="İpek Çelik"});
            users.Add(new User { Id = 36, RoleId = 1, Address = "Ankara", Email = "kny@gmail.com", FullName = "Kübranur Yalçınkaya" });
            users.Add(new User { Id = 46, RoleId = 2, Address = "İstanbul", Email = "fy@gmail.com", FullName = "Furkan Karaman" });
            users.Add(new User { Id = 56, RoleId = 2, Address = "Muğla", Email = "gy@gmail.com", FullName = "Doğa Yalçınkaya" });
            users.Add(new User { Id = 76, RoleId = 2, Address = "Malatya", Email = "bk@gmail.com", FullName = "Berra Kaya" });
            users.Add(new User { Id = 66, RoleId = 2, Address = "Mersin", Email = "ic@gmail.com", FullName = "Birsu Çelik" });
            return users;
        }
        public static List<Role> CreateRoleList()
        {
            List<Role> roles = new List<Role>();
            roles.Add(new Role { Id = 1, Name = "Admin" });
            roles.Add(new Role { Id = 2, Name = "System User" });
            return roles;
        }
    }
}