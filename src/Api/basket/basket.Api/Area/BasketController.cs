using basket.Api.Controllers;
using basket.Api.Entity.Basket;
using basket.Api.Repositery.BasketRepo;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace basket.Api.Area
{

    public class BasketController : BaseController
    {
        private readonly IBasketRepositery _basket;

        public BasketController(IBasketRepositery basket)
        {
            _basket = basket ?? throw new ArgumentNullException(nameof(basket));
        }

        [HttpGet("GetBasket")]
        public async Task<ActionResult<ShoppingCart>> GetBasket(string username)
        {

            var basket = await _basket.GetBasket(username);

            return Ok(basket ?? new ShoppingCart(username));
        }


        [HttpDelete("{userName}", Name = "DeleteBasket")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteBasket(string userName)
        {
            await _basket.DeleteBasket(userName);
            return Ok();
        }

        [HttpPost("UpdateBasket")]
        public async Task<ActionResult<ShoppingCart>> UpdateBasket(ShoppingCart model)
        {
            return Ok(await _basket.SetBasket(model));
        }


    }
}
