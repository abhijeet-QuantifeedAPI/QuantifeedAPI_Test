using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuantifeedWebAPI.Models
{
    public class Manager
    {

        [Key]
        public int ManagerId { get; set; }
        public string Position { get; set; }
        public int UserID { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
