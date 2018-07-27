using ProjetoHotelVS.BLL;
using ProjetoHotelVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoHotelVS.Controllers
{
    public class HotelController : Controller
    {
        static private ReservasService service = new ReservasService();
        // GET: Hotel
        public ActionResult Index()
        {
            List<uf> lista = service.listaUfs();
            IEnumerable<SelectListItem> ufs = new SelectList(lista, "uf_Id", "desc_uf");
            return View(ufs);
        }

        public ActionResult Lista(String uf)
        {
            List<Hotel> lista = service.listarHoteis(uf);
            return View(lista);
        }

        [HttpGet]
        public ActionResult Create()
        {
            List<uf> lista = service.listaUfs();
            IEnumerable<SelectListItem> ufs = new SelectList(lista, "uf_Id", "desc_uf");
            ViewBag.listaUf = ufs;
            Hotel hotel = new Hotel();
            return View(hotel);
        }
        [HttpPost]
        public ActionResult Create(Hotel hotel)
        {
            service.IncluirHotel(hotel);
            ViewBag.msg = "Hotel incluído com sucesso!";
            return View("Details", hotel);
        }

    }
}