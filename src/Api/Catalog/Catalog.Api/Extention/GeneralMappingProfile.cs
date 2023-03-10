using AutoMapper;
using Data.Entities.Catalog.Products;
using Dto.Catalog.Product;

namespace Catalog.Api.Extention
{
    public class GeneralMappingProfile : Profile
    {
        public GeneralMappingProfile()
        {
            #region Product

            CreateMap<Product, ProductDto>().ReverseMap();
            #endregion
        }
    }
}
