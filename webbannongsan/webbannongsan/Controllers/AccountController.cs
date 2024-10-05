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
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
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
        [ValidateAntiForgeryToken]
        public ActionResult Register(string ho, string ten, string email, string password, string phone, HttpPostedFileBase avatar)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem email đã tồn tại trong cơ sở dữ liệu chưa
                var existingUser = DB.Accounts.FirstOrDefault(u => u.Email == email);
                if (existingUser != null)
                {
                    return View();
                }

                // Xử lý tệp avatar
                string avatarPath = null;
                if (avatar != null && avatar.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(avatar.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Avatars"), fileName);
                    avatar.SaveAs(path);
                    avatarPath = "/Content/Avatars/" + fileName; // Lưu đường dẫn
                }

                // Tạo mới tài khoản người dùng
                var user = new Account
                {
                    AccountID= GenerateNewAccountId(),
                    FirstName = ho,
                    LastName = ten,
                    Email = email,
                    Password = BCrypt.Net.BCrypt.HashPassword(password), // Băm mật khẩu
                    PhoneNumber = phone,
                    Avatar = avatarPath,
                  
                };

                // Lưu vào cơ sở dữ liệu
                DB.Accounts.Add(user);
                DB.SaveChanges();

                // Chuyển hướng đến trang đăng nhập hoặc trang khác
                return RedirectToAction("Login", "Account");
            }

            return View();
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