using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
        
        public IQueryable<Actors> GetActors()
        {
            return context.Actors;
        }

        public Actors GetActorsById(Guid id)
        {
            return context.Actors.FirstOrDefault(x => x.Id == id);
        }
        public void SaveActors(Actors entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteActors(Guid id)
        {
            context.Actors.Remove(new Actors() { Id = id });
            context.SaveChanges();
        }
    }
}
