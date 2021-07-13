using System;
using System.Collections.Generic;
using System.Linq;
using siteMain.Domain.Entities;

namespace siteMain.Domain.Repositories.Abstract
{

    public interface IUserRateFilms
    {
        double GetUserRates(Guid id);
        IEnumerable<UserRatesFilm> GetUserByIdFilm(string id, string idUser);
        int GetUserMark(string idFilm, string idUser);
        void SaveUserRate(UserRatesFilm entity); // сохранить изменения
    }
}
