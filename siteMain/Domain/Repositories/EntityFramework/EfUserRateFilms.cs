using System;
using System.Linq;
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

        //public IQueryable<UserRatesFilm> GetUserByIdFilm(string idFilm, string nameUser)
        //{
        //    return _context.UserRateFilms.
        //        Where(x => x.IdFilm.ToString() == idFilm).
        //        Where(c => c.UserName == nameUser);
        //}

        //public int GetUserMark(string idFilm, string nameUser)
        //{
        //    return _context.UserRateFilms.
        //        Where(x => x.IdFilm.ToString() == idFilm).
        //        Where(c => c.UserName == nameUser).
        //        Select(b=>b.RateFilm).
        //        First();
        //}
    }
}
