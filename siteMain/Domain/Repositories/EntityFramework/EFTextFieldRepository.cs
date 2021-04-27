using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext context;
        public EFTextFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<TextFields> GetTextFields()
        {
            return context.TextFields;
        }

        public TextFields GetTextFieldsById(Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.Id == id);
        }

        public TextFields GetTextFieldsByCodeWord(string codeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveTextFields(TextFields entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteTextFields(Guid id)
        {
            context.TextFields.Remove(new TextFields() { Id = id });
            context.SaveChanges();
        }
    }
}
