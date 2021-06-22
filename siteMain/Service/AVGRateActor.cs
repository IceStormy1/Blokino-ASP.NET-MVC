using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain;

namespace siteMain.Service
{
    public class AvgRateActor
    {
        private readonly DataManager _dataManager;

        public AvgRateActor(DataManager dataManager)
        {
            this._dataManager = dataManager;
        }

        public void UpdateAvg(Guid id)
        {
            var actors = _dataManager.Actors.GetActorsById(id);
            var userRateActor = _dataManager.UserRateActors.GetUserRates(id);

            actors.AvgRateActor = (float)Math.Round(userRateActor, 2);

            _dataManager.Actors.SaveActors(actors);
        }
    }
}
