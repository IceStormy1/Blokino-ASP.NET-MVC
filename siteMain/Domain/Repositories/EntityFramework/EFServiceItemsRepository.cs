using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EfServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext _context;

        public EfServiceItemsRepository(AppDbContext context)
        {
            this._context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            
            return _context.ServiceItems;
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return _context.ServiceItems.
                Include(x => x.FilmsAndActors).
                ThenInclude(s => s.ServiceItem).
                FirstOrDefault(x => x.Id == id);
        }

        public ServiceItem GetServiceItemByFilmName(string filmName)
        {
            return _context.ServiceItems.FirstOrDefault(x => x.Title == filmName);
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                _context.Entry(entity).State = EntityState.Added;
            else
                _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            _context.ServiceItems.Remove(new ServiceItem() { Id = id });
            _context.SaveChanges();
        }
    }
}
