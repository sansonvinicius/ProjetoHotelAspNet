using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoHotelVS.Models;

namespace ProjetoHotelVS.DAL
{
    public class HotelDAO
    {
        public int IncluirHotel (Hotel hotel)
           
        {
            using (var db = new ReservasModel1())
            {
                db.Hotels.Add(hotel);
                db. SaveChanges();
                return hotel.Id;
                
            }
        }
        public List<Hotel> listar(string uf)
        {
            using (var db = new ReservasModel1())
            {
                List<Hotel> lista = db.Hotels.Where(h => h.Uf == uf).ToList();
                return lista;
            }
        }
    }
}