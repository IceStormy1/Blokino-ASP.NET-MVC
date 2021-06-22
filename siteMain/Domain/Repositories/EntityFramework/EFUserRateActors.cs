using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EfUserRateActors:IUserRateActors
    {
        private readonly AppDbContext _context;

        public EfUserRateActors(AppDbContext context)
        {
            this._context = context;
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

        public IQueryable<UserRatesActors> GetUserByIdFilm(string idFilm, string nameUser)
        {
            return _context.UserRatesActors.
                Where(x => x.IdActor.ToString() == idFilm).
                Where(c => c.UserName == nameUser);
        }
        public int GetUserMark(string idFilm, string nameUser)
        {
            return _context.UserRatesActors.
                Where(x => x.IdActor.ToString() == idFilm).
                Where(c => c.UserName == nameUser).
                Select(b => b.RateActor).First();
        }
    }
}
