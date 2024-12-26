using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCurso.Domain.Entidades
{
    public class Produto : EntidadeBasica
    {        
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
