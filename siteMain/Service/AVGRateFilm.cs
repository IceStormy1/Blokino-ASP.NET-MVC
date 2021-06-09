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
        
        public AVGRateFilm(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public void UpdateAVG(Guid id)
        {
            var serviceItem = dataManager.ServiceItems.GetServiceItemById(id);
            var userRate = dataManager.UserRate.GetUserRates(id);
            
           serviceItem.AvgRateFilm = (float)Math.Round(userRate,2);                                                                                                                                                                                                                                                           
           
            dataManager.ServiceItems.SaveServiceItem(serviceItem);
        }
    }
}
