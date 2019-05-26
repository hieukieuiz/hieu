using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanCafe.Models;

namespace WebBanCafe.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Web_ban_CafeEntities1 db = new Web_ban_CafeEntities1();
        public ActionResult Index()
        {

            string str = "";
            var product = (from a in db.PRODUCTs
                            join b in db.IMGs
                            on a.IMG_ID equals b.IMG_ID
                            where a.CATEGORY_ID == "01"
                            select new
                            {
                                ID = a.PRODUCT_ID,
                                Name = a.PRODUCT_NAME,
                                Price = a.PRICE,
                                Url = b.URL 
                            }).Take(4).ToList();
            for (int i = 0; i < product.Count; i++)
            { 
                str += "<div class=\"col-md-3\">";
                str += "<div class=\"menu-entry\">";
                str += "<a href = \"#\" class=\"img\" style=\"background-image: url('" + product[i].Url + "');\"></a>";
                str += "<div class=\"text text-center pt-4\">";
                str += "<h3><a href = \"product-single.html\" >" + product[i].Name + "</a ></h3>";
                str += "<p class=\"price\"><span>" + product[i].Price + " đ" + "</span></p>";
                str += "<p><a href = \"cart.html\" class=\"btn btn-primary btn-outline-primary\">Add to Cart</a></p>";
                str += "</div>";
                str += "</div>";
                str += "</div>";
            }
            ViewBag.Coffee = str;
            return View();
        }
     
    }
}