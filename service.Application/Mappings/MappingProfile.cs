using AutoMapper;
using service.Domain.Entities;
using service.Domain.Requests;
using service.Domain.Responses;

namespace service.Application.Mappings
{
    public class MappingProfile : Profile
    {

        public MappingProfile() {

            CreateMap<TestObject, TestResponse>();
            CreateMap<TestRequest, TestObject>();
        
        }


    }
}
