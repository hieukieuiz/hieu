using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanCafe.Models;
namespace WebBanCafe.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        Web_ban_CafeEntities1 db = new Web_ban_CafeEntities1();
        
        public ActionResult Index()
        {
            string str1= "";
            var product1 = (from a in db.PRODUCTs
                           join b in db.IMGs
                           on a.IMG_ID equals b.IMG_ID
                           where a.CATEGORY_ID =="01"
                           select new {
                               ID = a.PRODUCT_ID,
                               Name = a.PRODUCT_NAME,
                               Price = a.PRICE,
                               Url = b.URL
                           }).Take(8).ToList();
            for(int i=0; i<product1.Count; i++)
            {
                 str1 += "<div class=\"col-md-3\">";
                 str1 += "<div class=\"menu-entry\">";
                 str1 += "<a href = \"#\" class=\"img\" style=\"background-image: url('"+product1[i].Url+"');\"></a>";
                 str1 += "<div class=\"text text-center pt-4\">";
                 str1 += "<h3><a href = \"product-single.html\" >" +product1[i].Name+ "</a ></h3>";
                 str1 += "<p class=\"price\"><span>"+product1[i].Price +" đ"+"</span></p>";
                 str1 += "<p><a href = \"cart.html\" class=\"btn btn-primary btn-outline-primary\">Add to Cart</a></p>";
                 str1 += "</div>";
                 str1 += "</div>";
                 str1 += "</div>";
            }
            ViewBag.Coffee = str1;
            string str2 = "";
            var product2 = (from a in db.PRODUCTs
                           join b in db.IMGs
                           on a.IMG_ID equals b.IMG_ID
                           where a.CATEGORY_ID == "02"
                           select new
                           {
                               ID = a.PRODUCT_ID,
                               Name = a.PRODUCT_NAME,
                               Price = a.PRICE,
                               Url = b.URL
                           }).Take(6).ToList();
            for (int i = 0; i < product2.Count; i++)
            {
                str2 += "<div class=\"col-md-3\">";
                str2 += "<div class=\"menu-entry\">";
                str2 += "<a href = \"#\" class=\"img\" style=\"background-image: url('" + product2[i].Url + "');\"></a>";
                str2 += "<div class=\"text text-center pt-4\">";
                str2 += "<h3><a href = \"product-single.html\" >" + product2[i].Name + "</a ></h3>";
                str2 += "<p class=\"price\"><span>" + product2[i].Price + " đ" + "</span></p>";
                str2 += "<p><a href = \"cart.html\" class=\"btn btn-primary btn-outline-primary\">Add to Cart</a></p>";
                str2 += "</div>";
                str2 += "</div>";
                str2 += "</div>";
            }
            ViewBag.Tea = str2;
            string str3 = "";
            var product3 = (from a in db.PRODUCTs
                           join b in db.IMGs
                           on a.IMG_ID equals b.IMG_ID
                           where a.CATEGORY_ID == "03"
                           select new
                           {
                               ID = a.PRODUCT_ID,
                               Name = a.PRODUCT_NAME,
                               Price = a.PRICE,
                               Url = b.URL
                           }).Take(8).ToList();
            for (int i = 0; i < product3.Count; i++)
            {
                str3 += "<div class=\"col-md-3\">";
                str3 += "<div class=\"menu-entry\">";
                str3 += "<a href = \"#\" class=\"img\" style=\"background-image: url('" + product3[i].Url + "');\"></a>";
                str3 += "<div class=\"text text-center pt-4\">";
                str3 += "<h3><a href = \"product-single.html\" >" + product3[i].Name + "</a ></h3>";
                str3 += "<p class=\"price\"><span>" + product3[i].Price + " đ" + "</span></p>";
                str3 += "<p><a href = \"cart.html\" class=\"btn btn-primary btn-outline-primary\">Add to Cart</a></p>";
                str3 += "</div>";
                str3 += "</div>";
                str3 += "</div>";
            }
            ViewBag.Cake = str3;
            return View();
        }

    }
}