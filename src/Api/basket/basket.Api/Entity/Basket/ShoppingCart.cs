
using Basket.Api.Entity.Basket;

namespace basket.Api.Entity.Basket
{
    public class ShoppingCart
    {

        public string UserName { get; set; }

        public List<ShoppingCartItems> Items { get; set; } = new List<ShoppingCartItems>();

        public ShoppingCart()
        {

        }

        public ShoppingCart(string UserName)
        {
            UserName = UserName;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (var item in Items)
                {
                    total += item.Price * item.Qountity;
                }
                return total;
            }
        }
    }
}
