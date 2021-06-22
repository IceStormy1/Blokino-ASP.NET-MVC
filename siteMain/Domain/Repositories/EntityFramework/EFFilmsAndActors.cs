using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EfFilmsAndActors:IFilmsAndActors
    {
        private readonly AppDbContext _context;

        public EfFilmsAndActors(AppDbContext context)
        {
            this._context = context;
        }

        public void SaveFilmsAndActors(FilmsAndActors entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

       public IQueryable<FilmsAndActors> GetFilmsAndActors()
        {
            return _context.FilmsAndActors;
        }
    }
}
