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
            //var test = context.Actors
            //    .Include(x => x.FilmsAndActors.Select(y => y.ServiceItem)).ToList();
            //var test2 = context.Actors.Include(x => x.FilmsAndActors);
           // var test1 = context.FilmsAndActors.Include(x => x.ServiceItem).ToList();
           // var test3 = context.FilmsAndActors.Select(y => y.ServiceItem);
            
           // var test2 = context.Actors.Include(x => test3);
           //// var test4 = test3.Include(y => y.FilmsAndActors.Select(t => t.Actors)).ToList();

           var test5 = context.Actors.Include(x => x.FilmsAndActors).
               Include(x => x.FilmsAndActors).ThenInclude(s=>s.ServiceItem).FirstOrDefault(x => x.Id == id);
            return test5;
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
