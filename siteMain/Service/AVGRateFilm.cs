using System;
using siteMain.Domain;

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
            var films = _dataManager.Films.GetFilmsById(id);
            var userRate = _dataManager.UserRateFilms.GetUserRates(id);
            
           films.AvgRateFilm = (float)Math.Round(userRate,2);                                                                                                                                                                                                                                                           
           
            _dataManager.Films.SaveFilms(films);
        }
    }
}
