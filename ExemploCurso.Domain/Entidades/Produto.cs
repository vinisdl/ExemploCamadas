using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCurso.Domain.Entidades
{
    public class Produto : EntidadeBasica
    {        
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
