using System.ComponentModel.DataAnnotations;

namespace BrechówepApp.Models;

public class Porduto
{


    
    public required string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

     public required string UrlImagem { get; set; }
    
    public required string Descricao { get; set; }


    [RegularExpression("^(preto|branco|azul)$", ErrorMessage = "A cor deve ser preto, branco ou azul.")]
    public required string Cor { get; set; }

   
    public int Id { get; set; }
}
