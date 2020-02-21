using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuantifeedWebAPI.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public int Level { get; set; }
        public int UserID { get; set; }
        public int ManagerID { get; set; }
        public Manager Managers { get; set; }
    }
}
