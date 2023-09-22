using Negocio.Entidades.Comum;
using System.ComponentModel.DataAnnotations;
using Negocio.Validators;

namespace Negocio.Entidades
{
    public class Cargo : EntidadeBasica
    {
        [Required(ErrorMessage = "Nome é obrigatorio", AllowEmptyStrings = false)]
        [StringLength(50)]
        [MinLength(5, ErrorMessage = "Nome muito curto")]
        public string Nome { get; set; }

        public bool Status { get; set;}

        public Cargo(string nome, bool status) 
        {
            Nome = nome;
            Status = status;

            CriadoPor = "Welton";
            CriadoEm = DateTime.Now;

            AlteradoPor = "Welton";
            AlteradoEm = DateTime.Now;
        }
    }
}
