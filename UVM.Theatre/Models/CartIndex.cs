using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Models
{
    public class CartIndex
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}