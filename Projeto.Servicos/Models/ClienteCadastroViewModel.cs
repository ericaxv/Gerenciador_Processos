using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Servicos.Models
{
    public class ClienteCadastroViewModel
    {
        [Required(ErrorMessage ="Campo obrigatório, gentileza informar o nome do Cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, gentileza informar o Cnpj do Cliente")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, gentileza informar o Estado do Cliente")]
        public string Localizacao { get; set; }

    }
}