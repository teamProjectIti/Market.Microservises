using Microsoft.AspNetCore.Mvc;
using System;
using Dto.Catalog.Product;
using AutoMapper;
using Catalogs.Controllers;
using Catalogs.Entity.Products;

namespace Catalogs.Area
{
    public class ProductController : BaseController
    {
        private readonly IMongoRepository<Product> _ProductRepository;
        private readonly IMapper _mapper;

        public ProductController(IMongoRepository<Product> ProductRepository, IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
        }

        [HttpPost("AddProduct")]
        public async Task<ActionResult> AddProduct(ProductDto model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            var result = _mapper.Map<Product>(model);

            await _ProductRepository.InsertOneAsync(result);
            return Ok(result);
        }

        [HttpGet("GetAllProductData")]
        public async Task<ActionResult> GetAllProductData()
        {
            var product = _ProductRepository.AsQueryable();
            return Ok(product);
        }
        [HttpGet("getProductData")]
        public async Task<ActionResult> getProductData([FromQuery] string name)
        {
            var data = _ProductRepository.FilterBy(
                filter => filter.Name == name

            );
            return Ok(data);
        }

    }
}