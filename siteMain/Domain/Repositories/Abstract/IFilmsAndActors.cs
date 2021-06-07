using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;

namespace siteMain.Domain.Repositories.Abstract
{
    public interface IFilmsAndActors
    { 
        void SaveFilmsAndActors(FilmsAndActors entity);
    }
}
