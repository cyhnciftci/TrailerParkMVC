using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerParkMVC.Context;
using TrailerParkMVC.Models;

namespace TrailerParkMVC.Services
{
    public class CastService
    {
        private readonly DatabaseContext _db;


        public CastService(DatabaseContext db)
        {
            _db = db;
        }

        public List<Cast> GetAll()
        {
            return _db.Cast.ToList();
        }
        public Cast GetByID(int id)
        {
            return _db.Cast.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Cast entity)
        {
            _db.Cast.Add(entity);

            _db.SaveChanges();
        }
        public void Update(Cast entity)
        {
            _db.Cast.Update(entity);
            _db.SaveChanges();
        }
        public void Delete(Cast entity)
        {
            _db.Cast.Remove(entity);
            _db.SaveChanges();
        }

    }
}

