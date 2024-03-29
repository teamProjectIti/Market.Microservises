﻿using basket.Api.Entity.Basket;

namespace basket.Api.Repositery.BasketRepo
{
    public interface IBasketRepositery
    {
        Task<ShoppingCart> GetBasket(string usrename);
        Task<ShoppingCart> SetBasket(ShoppingCart model);
        Task DeleteBasket(string usrename);
    }
}
