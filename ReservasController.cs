using ProjetoHotelVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoHotelVS.Controllers
{
    public class ReservasController : Controller
    {
        // GET: Reservas
        // GET: Reservas
        [HttpGet]
        public ActionResult Index()
        {
            uf ufs = new uf();
            ufs.uf_id = "PR";
            ufs.desc_uf = "Parana";


            return View(ufs);
        }
        [HttpPost]
        public ActionResult Index(uf ufs)
        {

            if (ModelState.IsValid)
            {
                ViewData["msg"] = "ok";
            }
            return View(ufs);
        }
    }
}
