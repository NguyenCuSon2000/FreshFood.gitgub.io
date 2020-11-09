﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteFreshFood.Bussiness;
using WebsiteFreshFood.Models;

namespace WebsiteFreshFood.Areas.Admin.Controllers
{
    public class QLKhachHangController : Controller
    {
        QLKhachHangBus qlkh = new QLKhachHangBus();
        // GET: Admin/QLKhachHang
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public JsonResult GetKhachHang()
        {
            List<KhachHang> lsp = qlkh.LayAllKhachHang();
            return Json(lsp, JsonRequestBehavior.AllowGet);
        }
    }
}