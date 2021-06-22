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
    public class AvgRateFilm
    {
        private readonly DataManager _dataManager;
        
        public AvgRateFilm(DataManager dataManager)
        {
            this._dataManager = dataManager;
        }

        public void UpdateAvg(Guid id)
        {
            var serviceItem = _dataManager.ServiceItems.GetServiceItemById(id);
            var userRate = _dataManager.UserRate.GetUserRates(id);
            
           serviceItem.AvgRateFilm = (float)Math.Round(userRate,2);                                                                                                                                                                                                                                                           
           
            _dataManager.ServiceItems.SaveServiceItem(serviceItem);
        }
    }
}
