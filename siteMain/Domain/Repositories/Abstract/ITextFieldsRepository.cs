using System;
using System.Collections.Generic;
using System.Linq;
using siteMain.Domain.Entities;

namespace siteMain.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IEnumerable<TextFields> GetTextFields(); //выборка всех текстовых полей
        TextFields GetTextFieldsById(Guid id); //выбрать текстовое поле по id
        TextFields GetTextFieldsByCodeWord(string codeWord); // по кодовому слову
        void SaveTextFields(TextFields entity); // сохранить изменения
        void DeleteTextFields(Guid id); // удалить
    }
}
