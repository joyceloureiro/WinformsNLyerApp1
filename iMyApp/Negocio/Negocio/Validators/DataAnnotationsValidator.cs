using Microsoft.VisualBasic;
using Negocio.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Negocio.Validators
{
    public static partial class Validacoes
    {
        /// <summary>
        /// Valiada as DataAnnotations de uma classe.
        /// <example>Exemplo:
        /// <code>
        ///     var error = Validacao.getValidationErrror(obj);
        ///     fereach (var errror in erros)
        ///     {
        ///         Message.Box(("error.ErrorMessage"));
        ///     }
        /// </code>
        /// </example>
        /// <param name="obj">é a classe instanciada</param>
        /// <returns>Lista de erros</returns>
        /// </summary>
        
        public static IEnumerable<ValidationResult> ValidarDataAnotattion(Object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }

        
    }
    
}
