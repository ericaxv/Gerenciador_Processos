﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Servicos.Models
{
    public class ClienteConsultaViewModel
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Localizacao { get; set; }
    }
}