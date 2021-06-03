using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain;

namespace siteMain.Service
{
    public class AVGRateActor
    {
        private readonly DataManager dataManager;

        public AVGRateActor(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public void UpdateAVG(Guid id)
        {

            var actors = dataManager.Actors.GetActorsById(id);
            var userRateActor = dataManager.UserRateActors.GetUserRates(id);

            actors.AvgRateActor = (float)Math.Round(userRateActor, 2);

            // Сохранить изменения
            dataManager.Actors.SaveActors(actors);
        }
    }
}
