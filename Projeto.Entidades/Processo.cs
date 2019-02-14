using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Processo
    {
        public int IdProcesso { get; set; }
        public int IdCliente { get; set; }
        public string NumeroProcesso { get; set; }
        public string EstadoExecucao { get; set; } 
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public DateTime DataCriacao { get; set; }


        // relacionamento entre entidades
        public Cliente Cliente { get; set; }



    }
}
