using Descound.Api.Controllers;
using Descound.Api.Entity;
using Descound.Api.Repositery.Discound;
using Microsoft.AspNetCore.Mvc;

namespace Descound.Api.Area
{
    public class DiscoundController : BaseController
    {

        private readonly IDiscountRepository<Coupon> _discountRepository;
        public DiscoundController(IDiscountRepository<Coupon> _discountRepository)
        {
            this._discountRepository = _discountRepository;
        }
        [HttpGet("GetDiscountByName")]
        public async Task<IActionResult> GetDiscountByName([FromQuery] string Name)
        {
            var coupon = await _discountRepository.GetByNameAsync(Name);
            return Ok(coupon);
        }
        [HttpGet("GetDiscountById")]
        public async Task<IActionResult> GetDiscountById([FromQuery] int Id)
        {
            var coupon = await _discountRepository.GetByIdAsync(Id);
            return Ok(coupon);
        }
        [HttpPost("InsertDiscount")]
        public async Task<IActionResult> InsertDiscount([FromBody] Coupon model)
        {
            var coupon = await _discountRepository.AddAsync(model);
            return Ok(coupon);
        }
        [HttpPut("UpdateDiscount")]
        public async Task<IActionResult> UpdateDiscount([FromBody] Coupon model)
        {
            var coupon = await _discountRepository.UpdateAsync(model);
            return Ok(coupon);
        }
        [HttpDelete("DeleteDiscount")]
        public async Task<IActionResult> DeleteDiscount([FromQuery] int Id)
        {
            var coupon = await _discountRepository.DeleteAsync(Id);
            return Ok(coupon);
        }

        [HttpGet("GetAllDiscount")]
        public async Task<Coupon> GetAllDiscount()
        {
            var coupon = await _discountRepository.GetAllAsync();
            return coupon;
        }

    }
}