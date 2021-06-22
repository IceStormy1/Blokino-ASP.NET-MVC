using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EfTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext _context;
        public EfTextFieldsRepository(AppDbContext context)
        {
            this._context = context;
        }

        public IQueryable<TextFields> GetTextFields()
        {
            return _context.TextFields;
        }

        public TextFields GetTextFieldsById(Guid id)
        {
            return _context.TextFields.FirstOrDefault(x => x.Id == id);
        }

        public TextFields GetTextFieldsByCodeWord(string codeWord)
        {
            return _context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveTextFields(TextFields entity)
        {
            if (entity.Id == default)
                _context.Entry(entity).State = EntityState.Added;
            else
                _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteTextFields(Guid id)
        {
            _context.TextFields.Remove(new TextFields() { Id = id });
            _context.SaveChanges();
        }
    }
}
