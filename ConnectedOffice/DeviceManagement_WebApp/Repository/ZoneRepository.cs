using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static DeviceManagement_WebApp.Repository.ZoneRepository;

namespace DeviceManagement_WebApp.Repository
{
        public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
        {
            public ZoneRepository(ConnectedOfficeContext context) : base(context)
            {
            }

            public Zone GetMostRecentZone()
            {
                return _context.Zone.OrderByDescending(zone => zone.DateCreated).FirstOrDefault();
            }
        }


        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’

    
}
