using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;
using siteMain.Models;
using siteMain.Service;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EfUserRate : IUserRate
    {
        private readonly AppDbContext _context;
       
        public EfUserRate(AppDbContext context)
        {
            this._context = context;
        }

        public void SaveUserRate(UserRates entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public double GetUserRates(Guid id)
        {
            return _context.UserRate.
                Where(u => u.IdFilm == id).
                Average(p => p.RateFilm);
        }

        public IQueryable<UserRates> GetUserByIdFilm(string idFilm, string nameUser)
        {
            var asdfgads = _context.UserRate.
                Where(x => x.IdFilm.ToString() == idFilm).
                Where(c => c.UserName == nameUser);
            
            return _context.UserRate.
                Where(x => x.IdFilm.ToString() == idFilm).
                Where(c => c.UserName == nameUser);
        }

        public int GetUserMark(string idFilm, string nameUser)
        {
            return _context.UserRate.
                Where(x => x.IdFilm.ToString() == idFilm).
                Where(c => c.UserName == nameUser).
                Select(b=>b.RateFilm).
                First();
        }
    }
}
