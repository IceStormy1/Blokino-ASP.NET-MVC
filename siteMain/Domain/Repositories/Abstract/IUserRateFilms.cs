using System;
using System.Linq;
using siteMain.Domain.Entities;

namespace siteMain.Domain.Repositories.Abstract
{

    public interface IUserRateFilms
    {
        double GetUserRates(Guid id);
       // IQueryable<UserRatesFilm> GetUserByIdFilm(string id, string nameUser);
      //  int GetUserMark(string idFilm, string nameUser);
        void SaveUserRate(UserRatesFilm entity); // сохранить изменения
    }
}
