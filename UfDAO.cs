using ProjetoHotelVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoHotelVS.DAL
{
    public class UfDAO
    {
        public void insert(uf uf)
        {
            using (var db = new ReservasModel1())
            {
                db.ufs.Add(uf);
                db.SaveChanges();
            }
        }
        public void update(uf uf)
        {
            using (var db = new ReservasModel1())
            {
                db.ufs.Attach(uf);
                db.Entry(uf).Property(u => u.desc_uf).IsModified = true;
                db.SaveChanges();
            }
        }
        public void delete(string sigla)
        {
            using (var db = new ReservasModel1())
            {
                db.ufs.Remove(db.ufs.Find(sigla));
                db.SaveChanges();
            }
        }
        public uf find(string sigla)
        {
            using (var db = new ReservasModel1())
            {
                return db.ufs.Find(sigla);
            }
        }
        public List<uf> listaUfs()
        {
            using (var db = new ReservasModel1())
            {
                return db.ufs.ToList();
            }
        }
    }
}
    
