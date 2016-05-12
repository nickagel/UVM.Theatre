using System.Security.Policy;

namespace UVM.Theatre.Domain.Models
{
    public class Banner
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
    }
}