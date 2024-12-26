using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCurso.Domain.Entidades
{
    public abstract class EntidadeBasica
    {
        public required Guid Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; } 
    }
}
