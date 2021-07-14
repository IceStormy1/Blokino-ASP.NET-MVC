using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EfFilms : IFilms
    {
        private readonly AppDbContext _context;

        public EfFilms(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Films> GetFilms()
        {
            return _context.Films;
        }

        public Films GetFilmsById(Guid id)
        {
            return _context.Films.
                Include(x => x.FilmsAndActors).
                ThenInclude(s => s.Films).
                FirstOrDefault(x => x.Id == id);
        }

        public Films GetFilmsByFilmName(string filmName)
        {
            return _context.Films.FirstOrDefault(x => x.Title == filmName);
        }

        public void SaveFilms(Films entity)
        {
            if (entity.Id == default)
                _context.Entry(entity).State = EntityState.Added;
            else
                _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteFilms(Guid id)
        {
            _context.Films.Remove(new Films() { Id = id });
            _context.SaveChanges();
        }
    }
}
