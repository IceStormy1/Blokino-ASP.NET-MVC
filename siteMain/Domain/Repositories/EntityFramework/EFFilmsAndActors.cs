using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EFFilmsAndActors:IFilmsAndActors
    {
        private readonly AppDbContext context;

        public EFFilmsAndActors(AppDbContext context)
        {
            this.context = context;
        }

        public void SaveFilmsAndActors(FilmsAndActors entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
    }
}
