﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteFreshFood.Models;
using WebsiteFreshFood.Bussiness;

namespace WebsiteFreshFood.Areas.Admin.Controllers
{
    public class QLNhaCungCapController : BaseController
    {
        QLNhaCungCapBus qlncc = new QLNhaCungCapBus();
        // GET: Admin/QLNhaCungCap
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public JsonResult GetNhaCungCap()
        {
            List<NhaCungCap> lsp = qlncc.LayAllNhaCungCap();
            return Json(lsp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Search(string tenncc)
        {
            if (tenncc == "")
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
            else
            {
                List<NhaCungCap> lncc = qlncc.TimKiemNCC(tenncc);
                return Json(lncc, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult Insert(NhaCungCap n)
        {
            string res = qlncc.ThemNhaCungCap(n);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Update(NhaCungCap n)
        {
            string res = qlncc.SuaNhaCungCap(n);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Delete(string id)
        {
            string st = qlncc.XoaNhaCungCap(id);
            return Json(st, JsonRequestBehavior.AllowGet);
        }
    }
}