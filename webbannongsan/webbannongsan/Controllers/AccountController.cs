using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using webbannongsan.Models;

namespace webbannongsan.Controllers
{
    public class AccountController : Controller
    {
        DB_TadNongSanEntities DB = new DB_TadNongSanEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            
            var user = DB.Accounts.FirstOrDefault(u => u.Email == email && u.Password == password);
            ViewBag.user = user;
            if (user != null)
            {
                Session["Account"]=user;
                if(user.RoleID== "ADMIN")
                {
                    return RedirectToAction("ListProduct", "ProductAdmin", new { area = "Admin" });
                }
                return RedirectToAction("Index","Home");

            }
            else
            {
                ViewBag.ErrorMessage = "Thông tin đăng nhập không hợp lệ";
                return View();


            }
            
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Account model)
        {
            if (model == null)
            {
                return View(model);
            }
            if (string.IsNullOrEmpty( model.FirstName) == true)
            {
                return View(model);
            }
            if (string.IsNullOrEmpty(model.LastName) == true)
            {
                return View(model);
            }

            if (string.IsNullOrEmpty(model.Email))
            {
                return View(model);
            }
            else
            {
                var existingUser = DB.Accounts.FirstOrDefault(u => u.Email.ToLower() == model.Email.ToLower());
                if (existingUser != null)
                {
                    return View();
                }
            }
            if (string.IsNullOrEmpty(model.Password) == true)
            {
                return View(model);
            }
            if (string.IsNullOrEmpty(model.PhoneNumber)==true)
            {
                return View(model);
            }
            model.RoleID = "GUEST";
            DB.Accounts.Add(model);
            DB.SaveChanges();
            return RedirectToAction("Login");   
        }
        public ActionResult Profile()
        {
            Account Ac = (Account)Session["Account"];
            Account account = DB.Accounts.FirstOrDefault(i=>i.AccountID== Ac.AccountID);
            return View(account);
        }
        // Phương thức để tạo AccountId mới
        private int GenerateNewAccountId()
        {
            // Lấy tất cả AccountId trong cơ sở dữ liệu
            var existingIds = DB.Accounts.Select(a => a.AccountID).ToList();

            // Tìm AccountId lớn nhất và cộng thêm 1
            int newId = existingIds.Any() ? existingIds.Max() + 1 : 1; // Bắt đầu từ 1 nếu không có id nào

            return newId;
        }
    }
}