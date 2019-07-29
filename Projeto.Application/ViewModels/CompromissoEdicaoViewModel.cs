using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class CompromissoEdicaoViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int IdCompromisso { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public DateTime DataHora { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public int IdContato { get; set; }
    }
}
