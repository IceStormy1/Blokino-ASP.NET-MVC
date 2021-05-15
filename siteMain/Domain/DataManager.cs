﻿using System;
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
        public IRateUser RateUser { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository textServiceItemsRepository,IUserRate textUserRate, IRateUser textRateUser)
        {
            TextFields = textFieldsRepository;
            ServiceItems = textServiceItemsRepository;
            UserRate = textUserRate;
            RateUser = textRateUser;
        }
    }
}
