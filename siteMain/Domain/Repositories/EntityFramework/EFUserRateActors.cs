using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EFUserRateActors:IUserRateActors
    {
        private readonly AppDbContext context;

        public EFUserRateActors(AppDbContext context)
        {
            this.context = context;
        }

        public void SaveUserRate(UserRatesActors entity)
        {
            //context.Entry(entity).State = EntityState.Added;
            context.Add(entity);
            context.SaveChanges();
        }

        public double GetUserRates(Guid id)
        {
            return context.UserRatesActors.Where(u => u.IdActor == id).Average(p => p.RateActor);
        }

        public IQueryable<UserRatesActors> GetUserByIdFilm(string idFilm, string NameUser)
        {
            var asdfgads = context.UserRate.Where(x => x.IdFilm.ToString() == idFilm).Where(c => c.UserName == NameUser);

            return context.UserRatesActors.Where(x => x.IdActor.ToString() == idFilm).Where(c => c.UserName == NameUser);
        }
        public int GetUserMark(string idFilm, string NameUser)
        {
            return context.UserRatesActors.Where(x => x.IdActor.ToString() == idFilm).Where(c => c.UserName == NameUser).Select(b => b.RateActor).First();
        }
    }
}
