using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Servicos.Models
{
    public class ProcessoConsultaViewModel
    {     
        public int IdCliente { get; set; }      
        public string NumeroProcesso { get; set; }
        public string EstadoExecucao { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}