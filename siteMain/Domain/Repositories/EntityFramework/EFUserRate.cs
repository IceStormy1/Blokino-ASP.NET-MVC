﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;
using siteMain.Models;
using siteMain.Service;

namespace siteMain.Domain.Repositories.EntityFramework
{
    public class EFUserRate : IUserRate
    {
        private readonly AppDbContext context;
       
        public EFUserRate(AppDbContext context)
        {
            this.context = context;
        }
        public void SaveUserRate(UserRates entity)
        {
            //context.Entry(entity).State = EntityState.Added;
            context.Add(entity);
            context.SaveChanges();
        }

        
        
        public double GetUserRates(Guid id)
        {
            return context.UserRate.Where(u => u.IdFilm == id).Average(p => p.RateFilm);
        }

    }
}
