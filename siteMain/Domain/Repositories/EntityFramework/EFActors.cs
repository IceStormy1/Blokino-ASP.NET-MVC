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
            context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteActors(Guid id)
        {
            var test = context.FilmsAndActors.Where(c => c.IdActor == id);

            foreach (var entity in test)
            {
                context.FilmsAndActors.Remove(entity);
            }

            context.Actors.Remove(new Actors() { Id = id });
            context.SaveChanges();
        }
    }
}
