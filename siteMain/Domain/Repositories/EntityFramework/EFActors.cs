using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EFActors:IActors
    {
        private readonly AppDbContext context;
        public EFActors(AppDbContext context)
        {
            this.context = context;
        }
        public void SaveUserRate(Actors entity)
        {
            //context.Entry(entity).State = EntityState.Added;
            context.Add(entity);
            context.SaveChanges();
        }
    }
}
