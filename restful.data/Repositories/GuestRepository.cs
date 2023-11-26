using CreateApi;
using restful.core.Repository;
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.data.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly DataContext _dataContext;
        public GuestRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Guest> GetAllGuests()
        {
            return _dataContext.guests;
        }
    }
}
