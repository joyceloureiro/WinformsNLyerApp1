using Negocio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Cargo : EntidadeBasica
    {
        public string Nome { get; set; }

        public bool Status { get; set;}
    }
}
