using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Entities
{
    public class Compromisso
    {
        public int IdCompromisso { get; set; }
        public DateTime DataHora { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public int IdContato { get; set; }

        public Contato Contato { get; set; }
    }
}
