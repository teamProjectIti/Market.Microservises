using AutoMapper;
using Catalogs.Entity.Products;
using Dto.Catalog.Product;

namespace Catalogs.Extention
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
