using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Services
{
    public interface IOrderProcessorService
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}
