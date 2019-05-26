using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanCafe.Models;

namespace WebBanCafe.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: admin/Login
        Web_ban_CafeEntities1 db = new Web_ban_CafeEntities1();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ADMIN model)
        {
           
            if(ModelState.IsValid)
            {
                var Admin = db.ADMINs.SingleOrDefault(n => n.USERNAME == model.USERNAME);
                if (Admin == null)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else if (Admin.PASS_WORD != model.PASS_WORD)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng");

                }
                else return Redirect("/");
                return View();
            }
            return View(model);
        }
    }
}