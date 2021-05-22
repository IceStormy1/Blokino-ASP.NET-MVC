using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;
using siteMain.Models;

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