using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantifeedWebAPI.ViewModel
{
    public class ClientViewModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string Alias { get; set; }        
        public int Level { get; set; }
        public int? ManagerId { get; set; }      
        public string ManagerName { get; set; }
    }
}
