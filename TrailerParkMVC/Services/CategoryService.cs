using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerParkMVC.Context;
using TrailerParkMVC.Models;

namespace TrailerParkMVC.Services
{
    public class CategoryService
    {
        private readonly DatabaseContext _db;


        public CategoryService(DatabaseContext db)
        {
            _db = db;
        }

        public List<Categories> GetAll()
        {
            return _db.Categories.ToList();
        }
        public Categories GetByID(int id)
        {
            return _db.Categories.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Categories entity)
        {
            _db.Categories.Add(entity);

            _db.SaveChanges();
        }
        public void Update(Categories entity)
        {
            _db.Categories.Update(entity);
            _db.SaveChanges();
        }
        public void Delete(Categories entity)
        {
            _db.Categories.Remove(entity);
            _db.SaveChanges();
        }
        public List<MovieCategoryRelation> GetMovieCategoriesByMovieId(int id)
        {
            return _db.MovieCategoryRelation.Where(p => p.MovieId == id).ToList();
        }

    }
}

