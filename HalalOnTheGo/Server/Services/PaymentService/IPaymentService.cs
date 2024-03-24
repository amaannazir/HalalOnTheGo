using HalalOnTheGo.Shared;
using Stripe.Checkout;

namespace HalalOnTheGo.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Session CreateCheckoutSession(List<CartItem> cartItems); //Using stripe.checkout allows to access session which creates the checkout service session! Using the cartitems that is stored on the users local session.
    }
}
