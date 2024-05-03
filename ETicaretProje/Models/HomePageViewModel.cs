using Entities;
using Microsoft.Extensions.Hosting;

namespace ETicaretProje.Models
{
    public class HomePageViewModel
    {
        public List<Slide>? Slides { get; set; }
        public List<Category>? Categories { get; set; }
        public List<Product>? Products { get; set; }
        public List<Post>? Posts { get; set; }
    }
}
