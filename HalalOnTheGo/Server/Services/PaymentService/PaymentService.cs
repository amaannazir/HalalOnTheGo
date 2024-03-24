using HalalOnTheGo.Shared;
using Stripe;
using Stripe.Checkout;

namespace HalalOnTheGo.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService() // Constructor for the PaymentService
        {
            StripeConfiguration.ApiKey = "sk_test_51OxUxC2NH493X9svzVlQJ6yN4WoeQUui5aFEAt0dWRh3lGvp99D7cquiuoCnp0MOA9sdTz67OjlN8GIVHMQnyMYM00pnGQhfNt"; // Initializes the Stripe API key, enabling the service to securely interact with Stripe's payment infrastructure. FOR DEV TESTING ONLY, NOT A PRODUCTION! WHICH IS GOOD 

           
        }

        //THE FOLLOWING CODE BLOCK IS A METHOD TAKEN DIRECTLY FROM STRIPE DOCUMENTATION ("https://docs.stripe.com/payments/accept-a-payment"): 
        public Session CreateCheckoutSession(List<CartItem> cartItems) //Creates checkout session
        {

            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(ci => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions{
                  //To get the right value rather than showing 1000s
                  UnitAmountDecimal = ci.Price * 100, //Correct values
                  Currency = "GBP",
                  ProductData = new SessionLineItemPriceDataProductDataOptions //Product Data Attribute pulls the product information from cart item including the images, name, description etc. 
                  {
                      Name = ci.ProductTitle,
                     //Images = new List<string> { ci.Image }
                  }
                },
                Quantity = ci.Quantity
            }));

            var options = new SessionCreateOptions //The session is given a select amount of options such as payment, currency etc!
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",  //Payment type card - USES GOOGLE AND APPLE PAY! 
                },
                LineItems = lineItems, //LINE ITEMS ARE THE PRODUCTS IN THE CART - IT IS PULLING THE LINEITEM INFORMATION IN THE FUNCTION ON LINE 20!
               
                
                Mode = "payment",
                SuccessUrl = "https://localhost:7249/ordersuccess", //LOCAL MACHINE ONLY - NOT GO LIVE OR PRODUCTION KEY / URL!
                CancelUrl = "https://localhost:7249/cart",           //LOCAL MACHINE ONLY - NOT GO LIVE OR PRODUCTION KEY / URL!
            };

            var service = new SessionService();
            Session session = service.Create(options);

            return session;
            
        }
    }
}
