using AutoMapper;
using PurchaseManagerAPI.Entities;

namespace PurchaseManagerAPI.DTOs.Mapper
{
    public class ControllersProfile : Profile
    {
        public ControllersProfile()
        {
            CreateMap<CategoryAddModel, Category>();
            CreateMap<RecordAddModel, Record>();

            CreateMap<Record, RecordResponse>();
            CreateMap<Category, CategoryResponse>();
        }
    }
}
