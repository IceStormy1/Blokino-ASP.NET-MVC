using System;
using System.Linq;
using siteMain.Domain.Entities;

namespace siteMain.Domain.Repositories.Abstract
{
    public interface IActors
    {
        IQueryable<Actors> GetActors();
        public Actors GetActorsById(Guid id);
        public void SaveActors(Actors entity);
        public void DeleteActors(Guid id);
    }
}