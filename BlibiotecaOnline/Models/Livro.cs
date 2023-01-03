using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BlibiotecaOnline.Models
{
    public class Livro
    {
        public int LivroId { get; set; }

        [
            Display(Name = "Título"),
            MaxLength(50),
            Required
        ]
        public string Titulo { get; set; } = string.Empty;

        [
            Required,
            StringLength(50)
        ]
        public string Autor { get; set; } = string.Empty;


        [
            Required,
            StringLength(20)
        ]
        public string ISBN { get; set; } = string.Empty;
    }
}
