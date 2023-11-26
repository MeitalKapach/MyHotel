using restful.core.Repository;
using restful.core.Services;
using restful.Entities;
using static restful.service.RoomService;


namespace restful.service
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
           _roomRepository = roomRepository;
        }

        public List<Room> GetRooms()
        {
            return _roomRepository.GetAllRooms();
        }

    }
}