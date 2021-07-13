using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EfUserRateFilms : IUserRateFilms
    {
        private readonly AppDbContext _context;
       
        public EfUserRateFilms(AppDbContext context)
        {
            _context = context;
        }

        public void SaveUserRate(UserRatesFilm entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public double GetUserRates(Guid id)
        {
            return _context.UserRateFilms.
                Where(u => u.IdFilm == id).
                Average(p => p.RateFilm);
        }

        public IEnumerable<UserRatesFilm> GetUserByIdFilm(string idFilm, string idUser)
        {
            return _context.UserRateFilms
                .Include(c => c.Films)
                .Include(v => v.Users)
                .ToList()
                .Where(b => b.IdFilm.ToString() == idFilm && b.UsersId == idUser);
        }

        public int GetUserMark(string idFilm, string idUser)
        {
            return _context.UserRateFilms
                .Where(b => b.IdFilm.ToString() == idFilm && b.UsersId == idUser)
                .Select(c => c.RateFilm).First();
        }
    }
}
