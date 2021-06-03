using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public  IServiceItemsRepository ServiceItems { get; set; }
       
        public IUserRate UserRate { get; set; }
        public IActors Actors { get; set; }
        public IUserRateActors UserRateActors { get; set; }
        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository textServiceItemsRepository, IUserRate textUserRate, IActors textActors, IUserRateActors textUserRateActors)
        {
            TextFields = textFieldsRepository;
            ServiceItems = textServiceItemsRepository;
            UserRate = textUserRate;
            Actors = textActors;
            UserRateActors = textUserRateActors;
        }

    }
}
