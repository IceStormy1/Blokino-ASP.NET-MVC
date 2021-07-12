using System;
using System.Linq;
using siteMain.Domain.Entities;

namespace siteMain.Domain.Repositories.Abstract
{
    public interface IFilms
    {
        IQueryable<Films> GetFilms(); //выборка всех текстовых полей
        Films GetFilmsById(Guid id); //выбрать текстовое поле по id
        void SaveFilms(Films entity); // сохранить изменения
        void DeleteFilms(Guid id); // удалить услугу
        Films GetFilmsByFilmName(string filmName);
    }
}
