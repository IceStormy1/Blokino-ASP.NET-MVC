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
        void SaveUserRate(Actors entity); // сохранить изменения
    }
}