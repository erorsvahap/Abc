using Entities.Concrete;

namespace WebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);

    }
}
