using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;
using siteMain.Models;

namespace siteMain.Domain.Repositories.Abstract
{

    public interface IUserRate
    {
        double GetUserRates(Guid id);
        IQueryable<UserRates> GetUserByIdFilm(string id, string nameUser);
        int GetUserMark(string idFilm, string nameUser);
        void SaveUserRate(UserRates entity); // сохранить изменения
    }
}
