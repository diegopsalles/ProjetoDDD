using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class EnderecoCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cep { get; set; }
    }
}
