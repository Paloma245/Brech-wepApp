using BrechówepApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BrechówepApp.Pages
{
    public class DetailsModel : PageModel
    {
        public required Porduto Produto { get; set; }
        public void OnGet(int id)
        {
            var service = new ProdutoService();
           Produto =  service.Obter(id);




        }
    }
}
