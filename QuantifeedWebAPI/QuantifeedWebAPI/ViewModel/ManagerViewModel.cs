using QuantifeedWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantifeedWebAPI.ViewModel
{
    public class ManagerViewModel
    {
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string Alias { get; set; }
        public string Position { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }        
       // public ICollection<Client> Clients { get; set; }
    }
}
