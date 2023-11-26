using restful.core.Repository;
using restful.core.Services;
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.service
{
    public class GuestService:IGuestService
    {

        private readonly IGuestRepository _guestRepository;
        public GuestService(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }


        public List<Guest> GetGuests()
        {
            return _guestRepository.GetAllGuests();
        }
   

    }
}
