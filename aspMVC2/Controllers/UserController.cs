using aspMVC2.FakeDataHelper;
using aspMVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspMVC2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<Models.User> userList = VeriUret.CreateUserList();
            List<Models.Role> roleList = VeriUret.CreateRoleList();
            //View modelin içinde barındırmak için 1.yol
            UserRoleViewModel model = new UserRoleViewModel { Roles = roleList, Users = userList };

            return View(model);
        }
        public ActionResult FilterByRole(int id)
        {
            //Seçilen role ait kullanıcıları bulur.
            Role selectedRole = VeriUret.CreateRoleList().Find(x => x.Id == id);
            
            //Admin Rolündeki veya SystemUser Rolündeki verileri getir.
            List<Models.User> userList = VeriUret.CreateUserList().Where(x=> x.RoleId==id).ToList();

            //Veri taşımaya yarayan parametre
            ViewBag.Message = selectedRole.Name + " Rolüne sahip kullanıcılar listelenmiştir. (ViewBag ile gönderildi.) ";
            ViewBag.Count = userList.Count + "   -  adet kayıt bulundu. (ViewBag ile gönderildi.)";

            ViewData["VDMessage"] = selectedRole.Name + "Rolüne sahip kullanıcılar listelenmiştir. (ViewData ile gönderildi.)";
            return View(userList);
        }
        public ActionResult Page1()
        {
            TempData["TDMessage"] = "Page 1 Action'unda oluşturulan veri gönderild.";
            return RedirectToAction(nameof(Page2));
        }
        public ActionResult Page2()
        {
            var data = TempData["TDMessage"]; 
            return View();
        }
    }
}