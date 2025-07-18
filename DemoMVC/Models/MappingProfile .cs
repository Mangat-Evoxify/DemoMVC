using AutoMapper;
using DemoMVC.Entities;
namespace DemoMVC.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
            CreateMap<ProductViewModel, Product>().ReverseMap();
        }
    }
}
