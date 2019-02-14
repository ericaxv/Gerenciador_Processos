using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using Projeto.Entidades;

namespace Projeto.Repositorio
{
    public class ClienteRepositorio
    {      
        //armazenando a connectiostring
        private string connectionString = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;

        //inserindo Cliente

        public void Insert(Cliente c)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "Insert into Cliente (Nome, Cnpj, Localizacao) values(@Nome,  @Cnpj, @Localizacao)";

                con.Execute(query, c);
            }
        }

        //buscando clientes cadastrados
        public List<Cliente> FindAll()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "Select * from Cliente";

                return con.Query<Cliente>(query).ToList();
            }
        }
    }
}
