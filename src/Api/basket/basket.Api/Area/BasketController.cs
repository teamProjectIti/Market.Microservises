using AutoMapper;
using basket.Api.Controllers;
using basket.Api.Entity.Basket;
using basket.Api.Entity.CeckOut;
using basket.Api.Repositery.BasketRepo;
using EventBus.Message.Events;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace basket.Api.Area
{

    public class BasketController : BaseController
    {
        private readonly IBasketRepositery _basket;
        private readonly IMapper _mapper;
        private readonly IPublishEndpoint _publishEndpoint;

        public BasketController(IBasketRepositery basket, IMapper mapper, IPublishEndpoint publishEndpoint)
        {
            _basket = basket ?? throw new ArgumentNullException(nameof(basket));
            _mapper = mapper;
            _publishEndpoint = publishEndpoint;
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
         [HttpPost("Checkout")]
         public async Task<IActionResult> Checkout([FromBody] BasketCheckout basketCheckout)
        {
            var basketDb = await _basket.GetBasket(basketCheckout.UserName);
            if (basketDb is null)
                return BadRequest("not Found Any basket");


            // send checkout event to rabbitmq
            var eventMessage = _mapper.Map<BasketCheckoutEvent>(basketCheckout);
            eventMessage.TotalPrice = basketDb.TotalPrice;

            await _publishEndpoint.Publish(eventMessage);



            await _basket.DeleteBasket(basketCheckout.UserName);

            return Accepted();

        }

    }
    }
