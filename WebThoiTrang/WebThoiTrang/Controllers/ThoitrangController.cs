using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebThoiTrang.Models;

namespace WebThoiTrang.Controllers
{
    public class ThoitrangController : Controller
    {
        // GET: Thoitrang
        public ActionResult thoitrang()
        {
            QLCuaHangEntities1 db = new QLCuaHangEntities1();
            List<sanpham> kqsanpham = new List<sanpham>();
            return View( kqsanpham);
        }
     
    }
}