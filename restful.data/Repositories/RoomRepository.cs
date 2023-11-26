using restful.core.Repository;
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly IRoomRepository _roomRepository;
        public RoomRepository(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public List<Room> GetAllRooms()
        {
           return _roomRepository.GetAllRooms();
        }
    }
}
