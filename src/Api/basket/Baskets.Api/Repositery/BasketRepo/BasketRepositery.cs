using Baskets.Api.Entity.Basket;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Baskets.Api.Repositery.BasketRepo
{
    public class BasketRepositery : IBasketRepositery
    {
        private readonly IDistributedCache _distributedCache;

        public BasketRepositery(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public async Task<ShoppingCart> GetBasket(string userName)
        {
            var basket = await _distributedCache.GetStringAsync(userName);

            if (string.IsNullOrEmpty(basket))
                return null;

            return JsonConvert.DeserializeObject<ShoppingCart>(basket);
        }

        public async Task<ShoppingCart> SetBasket(ShoppingCart basket)
        {
            await _distributedCache.SetStringAsync(basket.UserName, JsonConvert.SerializeObject(basket));

            return await GetBasket(basket.UserName);
        }
        public async Task DeleteBasket(string userName)
        {
            await _distributedCache.RemoveAsync(userName);
        }

    }
}
