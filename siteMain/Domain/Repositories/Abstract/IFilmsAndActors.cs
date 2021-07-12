using System.Linq;
using siteMain.Domain.Entities;

namespace siteMain.Domain.Repositories.Abstract
{
    public interface IFilmsAndActors
    { 
        void SaveFilmsAndActors(FilmsAndActors entity);
        IQueryable<FilmsAndActors> GetFilmsAndActors();
    }
}
