using Entities.Concrete;

namespace WebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; internal set; }
        public List<Category> Categories { get; internal set; }
    }
}
