using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;

namespace siteMain.Domain.Repositories.Abstract
{
    public interface IUserRateActors
    {
        double GetUserRates(Guid id);
        IQueryable<UserRatesActors> GetUserByIdFilm(string id, string nameUser);
        int GetUserMark(string idFilm, string nameUser);
        void SaveUserRate(UserRatesActors entity); // сохранить изменения
    }
}
