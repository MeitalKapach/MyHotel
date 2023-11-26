
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core.Repository
{
    public interface IGuestRepository
    {
        List<Guest> GetAllGuests();
    }
}
