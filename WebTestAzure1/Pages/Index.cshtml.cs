using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTestAzure1.Models;
using WebTestAzure1.Services;

namespace WebTestAzure1.Pages
{
    public class IndexModel : PageModel
    {
      public List<Product> Products;  
      public void OnGet()
      {
         var productService = new ProductService();
         Products = productService.GetProducts();
      }
    }
}