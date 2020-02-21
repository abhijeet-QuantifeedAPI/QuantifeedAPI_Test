using Microsoft.EntityFrameworkCore;
using QuantifeedWebAPI.Data;
using QuantifeedWebAPI.Models;
using QuantifeedWebAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantifeedWebAPI.Repository
{
    public class ManagerRepository : IManagerRepository
    {

        QuantifeedDbContext db;
        public ManagerRepository(QuantifeedDbContext _db)
        {
            db = _db;
        }

        public async Task<List<ManagerViewModel>> GetManagers()
        {
            if (db != null)
            {
                return await (from p in db.Managers
                              from c in db.Clients
                              where p.ManagerId == c.ManagerID
                              from u in db.Users
                              where p.UserID == u.UserId
                              from m in db.Users
                              where c.UserID == m.UserId
                              select new ManagerViewModel
                              {
                                  ManagerId = p.ManagerId,
                                  ManagerName = u.UserName,
                                  ManagerFirstName = u.UserName,
                                  ManagerLastName = u.LastName,
                                  Alias = u.Alias,
                                  Position = p.Position,
                                  ClientId = c.ClientId,
                                  ClientName = m.UserName,                               
                              }).ToListAsync();
            }

            return null;
        }

        public async Task<List<ManagerViewModel>> GetManager(string UserName)
        {
            if (db != null)
            {
                return await (from p in db.Managers
                              from c in db.Clients
                              where p.ManagerId == c.ManagerID 
                              from u in db.Users
                              where p.UserID == u.UserId 
                              from m in db.Users
                              where c.UserID == m.UserId
                              where u.UserName == UserName
                              select new ManagerViewModel
                              {
                                  ManagerId = p.ManagerId,
                                  ManagerName = u.UserName,
                                  ManagerFirstName = u.UserName,
                                  ManagerLastName = u.LastName,
                                  Alias = u.Alias,
                                  Position = p.Position,
                                  ClientId = c.ClientId,
                                  ClientName = m.UserName,
                              }).ToListAsync();
            }

            return null;
        }
    }
}
