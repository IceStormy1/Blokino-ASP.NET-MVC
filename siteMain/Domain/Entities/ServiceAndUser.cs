using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siteMain.Domain.Entities
{
    public class ServiceAndUser
    {
        public ServiceItem ServiceItems { get; set; }
        public UserRate UserRate { get; set; }
    }
}
