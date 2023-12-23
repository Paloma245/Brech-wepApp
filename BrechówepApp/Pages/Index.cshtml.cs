using BrechówepApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.ConstrainedExecution;

namespace BrechówepApp.Pages;

public class IndexModel : PageModel
{
    public IList<Porduto>? ListaProduto { get; set; }
    public required string Mensagem { get; set; }
    public string? Descricao { get; private set; }
    public string? UrlImagem { get; private set; }
    public string? Cor { get; private set; }
    public Var? ProdutoService { get; private set; }

    public void OnPost()
    {
        
    }

    public void OnGet()
    {

        ViewData["Title"] = "Home page";

        var service = new ProdutoService();

        ListaProduto = service.ObterTodos();

}
}
