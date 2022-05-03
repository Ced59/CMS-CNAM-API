using AutoMapper;
using Dto.UsersDto;
using Entities.UsersEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, UserPostDto>().ForMember(x => x.PasswordCheck, opt => opt.Ignore()); ;
        }

        private void MapDtoToEntities()
        {
            CreateMap<UserDto, User>()
                .ForMember(x => x.Password, opt => opt.Ignore())
                .ForMember(x => x.PasswordId, opt => opt.Ignore())
                .ForMember(x => x.IsArchived, opt => opt.Ignore());
            CreateMap<UserPostDto, User>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.PasswordId, opt => opt.Ignore())
                .ForMember(x => x.IsArchived, opt => opt.Ignore());
        }
    }
}
