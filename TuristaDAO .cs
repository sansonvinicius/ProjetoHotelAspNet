using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoHotelVS.Models;

namespace ProjetoHotelVS.DAL
{
    public class TuristaDAO
    {
        public int IncluirTurista (Turista turista)
           
        {
            using (var db = new ReservasModel1())
            {
                db.Turistas.Add(turista);
                db.SaveChanges();
                return turista.Id;
            }

            


        }
    }
}