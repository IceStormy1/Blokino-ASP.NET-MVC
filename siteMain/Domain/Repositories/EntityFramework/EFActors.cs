using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EfActors:IActors
    {
        private readonly AppDbContext _context;

        public EfActors(AppDbContext context)
        {
            this._context = context;
        }
        
        public IQueryable<Actors> GetActors()
        {
            return _context.Actors;
        }

        public Actors GetActorsById(Guid id)
        {
            return _context.Actors.
                Include(x => x.FilmsAndActors).
                ThenInclude(s => s.ServiceItem).
                FirstOrDefault(x => x.Id == id);
        }
        public void SaveActors(Actors entity)
        {
            _context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteActors(Guid id)
        {
            var test = _context.FilmsAndActors.Where(c => c.IdActor == id);

            foreach (var entity in test)
            {
                _context.FilmsAndActors.Remove(entity);
            }

            _context.Actors.Remove(new Actors() { Id = id });
            _context.SaveChanges();
        }
    }
}
