using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MioSito.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WriteCookie(string cookieName, string cookieValue, bool persistente)
        {
            CookieOptions cookies = new CookieOptions();
            cookies.Expires = DateTime.Now.AddDays(1);
            if (persistente)
            {
                Response.Cookies.Append(cookieName, cookieValue, cookies);
            }
            else
            {
                Response.Cookies.Append(cookieName, cookieValue);
            }
            ViewBag.message = "Cookie aggiunti";

            return View("Index");
        }
        public IActionResult ReadCookie()
        {
            ViewBag.cookieValue = Request.Cookies["UserName"].ToString();

            return View();
        }
    }
}