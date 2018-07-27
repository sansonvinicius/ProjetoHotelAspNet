using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoHotelVS.Controllers
{
    public class VersionController : Controller
    {
        // GET: Version
        public String Index()
        {
            return "V1.0";
        }
    }
}