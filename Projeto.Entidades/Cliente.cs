using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Localizacao { get; set; }
        

        // relacionamento entre entidades
        public List<Processo> Processos { get; set; }

    }
}
