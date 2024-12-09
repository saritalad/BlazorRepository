using BlazorServerApp.Models;

namespace BlazorServerApp.Services
{
    public class CartService
    {
        public List<Product> SelectedItems { get; set; } = new();
        public void AddProductToCart(Guid productId)
        {
            var product = ProductService.Products.First(p => p.Id == productId);

            if (SelectedItems.Contains(product) is false)
            {
                SelectedItems.Add(product);
            }
        }
    }
}
