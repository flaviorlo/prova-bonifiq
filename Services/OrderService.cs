using ProvaPub.Models;

namespace ProvaPub.Services
{
	public class OrderService
	{
		public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			var method = Method();

			if(!method.ToList().Contains(paymentMethod.ToUpper()))
			{
				//Faz pagamento.				
            }
            

			return await Task.FromResult( new Order()
			{
				Value = paymentValue,
				OrderDate=DateTime.Now,
			});
		}

		public List<string> Method()
		{
			List<string> payment = new List<string> { 
			
				"pix",
                "CREDITCARD",
                "PAYPAL"
            };


			return payment;
		}
	}
}
