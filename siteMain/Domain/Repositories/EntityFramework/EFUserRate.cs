using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EFUserRate : IUserRate
    {
        private readonly AppDbContext context;
        public void SaveUserRate(UserRate entity)
        {
            context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
        }
    }
}
