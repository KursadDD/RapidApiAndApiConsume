using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();
            
            //reversemap dediğimiz zaman tersiniz tekrar yazmamıza gerek yok iki taraflı olarak map ediyor
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
