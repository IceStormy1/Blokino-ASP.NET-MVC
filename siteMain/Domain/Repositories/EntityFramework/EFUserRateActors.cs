using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EfUserRateActors:IUserRateActors
    {
        private readonly AppDbContext _context;

        public EfUserRateActors(AppDbContext context)
        {
            _context = context;
        }

        public void SaveUserRate(UserRatesActors entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public double GetUserRates(Guid id)
        {
            return _context.UserRatesActors.
                Where(u => u.IdActor == id).
                Average(p => p.RateActor);
        }

        public IEnumerable<UserRatesActors> GetUserByIdFilm(string idFilm, string idUser)
        {
            return _context.UserRatesActors
                .Include(c => c.Actors)
                .Include(v => v.Users)
                .ToList()
                .Where(b => b.IdActor.ToString() == idFilm && b.UsersId == idUser);
        }

        public int GetUserMark(string idFilm, string idUser)
        {
            try
            {
                return _context.UserRatesActors
                    .Where(b => b.IdActor.ToString() == idFilm && b.UsersId == idUser)
                    .Select(c => c.RateActor).First();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
