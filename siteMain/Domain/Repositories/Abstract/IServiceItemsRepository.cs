using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using siteMain.Domain.Entities;

namespace siteMain.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems(); //выборка всех текстовых полей
        ServiceItem GetServiceItemById(Guid id); //выбрать текстовое поле по id
        void SaveServiceItem(ServiceItem entity); // сохранить изменения
        void DeleteServiceItem(Guid id); // удалить услугу
        ServiceItem GetServiceItemByFilmName(string FilmName);
    }
}
