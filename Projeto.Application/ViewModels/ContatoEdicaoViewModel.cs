using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class ContatoEdicaoViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int IdContato { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Email inválido.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Telefone { get; set; }
    }
}
