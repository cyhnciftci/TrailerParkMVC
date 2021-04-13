using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerParkMVC.Context;
using TrailerParkMVC.Models;

namespace TrailerParkMVC.Services
{
    public class MovieService
    {
        private readonly DatabaseContext _db;


        public MovieService(DatabaseContext db)
        {
            _db = db;
        }

        public List<Movies> GetAll()
        {
            return _db.Movies.ToList();
        }
        public Movies GetByID(int id)
        {
            return _db.Movies.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Movies entity)
        {
            _db.Movies.Add(entity);
                
            _db.SaveChanges();
        }
        public void Update(Movies entity)
        {
            _db.Movies.Update(entity);
            _db.SaveChanges();
        }
        public void Delete(Movies entity)
        {
            _db.Movies.Remove(entity);
            _db.SaveChanges();
        }

    }
}
