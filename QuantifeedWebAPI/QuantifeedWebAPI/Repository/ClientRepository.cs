using QuantifeedWebAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuantifeedWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using QuantifeedWebAPI.Data;

namespace QuantifeedWebAPI.Repository
{
    public class ClientRepository : IClientRepository
    {
        QuantifeedDbContext db;
        public ClientRepository(QuantifeedDbContext _db)
        {
            db = _db;
        }

        public async Task<List<ClientViewModel>> GetClients()
        {
            if (db != null)
            {
                return await(from p in db.Clients
                             from c in db.Managers
                             where p.ManagerID == c.ManagerId
                             from u in db.Users
                             where p.UserID == u.UserId
                             from m in db.Users
                             where c.UserID == m.UserId
                             select new ClientViewModel
                             {
                                 ClientId = p.ClientId,
                                 ClientName = u.UserName,
                                 ClientFirstName = u.UserName,
                                 ClientLastName =u.LastName,
                                 Alias = u.Alias,
                                 Level = p.Level,
                                 ManagerId = c.ManagerId,
                                 ManagerName = m.UserName,
                                
                             }).ToListAsync();
            }

            return null;
        }
    }
}
