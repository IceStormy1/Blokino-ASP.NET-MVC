using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using siteMain.Domain;
using siteMain.Domain.Entities;

namespace siteMain.Service
{
    public class AVGRateFilm
    {
       
        private readonly DataManager dataManager;
        UserManager<IdentityUser> _manager;
       
        public AVGRateFilm(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public void UpdateAVG(Guid id)
        {
            //var customer = context.ServiceItems.First(c => c.Id == id);
            var serviceItem = dataManager.ServiceItems.GetServiceItemById(id);
            var userRate = dataManager.UserRate.GetUserRates(id);
            //var upd = userRate
            //var AVG = context.ServiceItems.AverageAsync(c=>c.UserRates.)
            //var UpdateAvg = context.ServiceItems.Average(c => c.AvgRateFilm);
            //var UpdateAvg = context.ServiceItems.Where(u => u.Id == id)
           //     .Average(context.UserRate.Where(p => p.RateFilm));
           serviceItem.AvgRateFilm = (float)userRate;                                                                                                                                                                                                                                                           
            
            // Сохранить изменения
            dataManager.ServiceItems.SaveServiceItem(serviceItem);
        }
    }
}
