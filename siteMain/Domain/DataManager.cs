using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public  IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository textServiceItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = textServiceItemsRepository;
        }
    }
}
