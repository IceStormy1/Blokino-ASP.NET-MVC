using System;
using System.Linq;
using siteMain.Domain.Entities;

namespace siteMain.Domain.Repositories.Abstract
{
    public interface IUserRateActors
    {
        double GetUserRates(Guid id);
        //IQueryable<UserRatesActors> GetUserByIdFilm(string id, string nameUser);
       // int GetUserMark(string idFilm, string nameUser);
        void SaveUserRate(UserRatesActors entity); // сохранить изменения
    }
}
