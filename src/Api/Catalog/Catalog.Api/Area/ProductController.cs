using Catalog.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using static Catalog.Api.repositery.Product.IMongoRepository;
using System;
using Data.Entities.Catalog.Products;
using Dto.Catalog.Product;
using AutoMapper;

namespace Catalog.Api.Area
{
    public class ProductController : BaseController
    {
        private readonly IMongoRepository<Product> _peopleRepository;
        private readonly IMapper _mapper;

        public ProductController(IMongoRepository<Product> peopleRepository, IMapper mapper)
        {
            _peopleRepository = peopleRepository;
            _mapper = mapper;
        }

        [HttpPost("registerPerson")]
        public async Task AddPerson(ProductDto model)
        {

            var result = _mapper.Map<Product>(model);

            await _peopleRepository.InsertOneAsync(result);
        }

        [HttpGet("getProductData")]
        public IEnumerable<string> getProductData()
        {
            var people = _peopleRepository.FilterBy(
                filter => filter.Name != "test",
                projection => projection.Name
            );
            return people;
        }
    }
}