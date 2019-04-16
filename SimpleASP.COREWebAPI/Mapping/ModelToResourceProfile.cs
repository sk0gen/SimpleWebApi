using AutoMapper;
using LearnApi.Domain.Models;
using LearnApi.Extensions;
using LearnApi.Resources;

namespace LearnApi.Mapping
{
    public class ModelToResourceProfile : Profile
    {

        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>().ForMember(src => src.UnitOfMeasurement,
                opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));

        }



    }
}
