using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizzashop.Model;

namespace Pizzashop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzashopController : ControllerBase
    {

        // GET: 
        public Summary GetOrderPizza()
        {        
            
            Pizza pizza1 = new Pizza(Pizza.Size.Large, new List<string> { "Cheese", "Pepperoni", "Mushrooms" });
            Pizza pizza2 = new Pizza(Pizza.Size.Medium, new List<string> { "Chicken", "Pineapple", "Prosciutto", "Bacon" });

            Order order = new Order();
            order.AddPizza(pizza1);
            order.AddPizza(pizza2);

            Summary sum = new Summary();
            sum.TotalPrice = order.CalculateTotalPrice();
            sum.CountPizza = order.CalculateCountPizza();



            return sum;
        }
    }
}
