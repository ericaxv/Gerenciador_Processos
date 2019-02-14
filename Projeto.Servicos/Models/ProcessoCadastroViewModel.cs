using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Servicos.Models
{
    public class ProcessoCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório, gentileza informar o Id do Cliente")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, gentileza informar o Número do Processo")]
        public string NumeroProcesso { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, gentileza informar o Estado de excução do Processo")]
        public string EstadoExecucao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, gentileza informar o Valor do Processo")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, gentileza informar o Status do Processo")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, gentileza informar a data do Processo")]
        public DateTime DataCriacao { get; set; }

        
    }
}