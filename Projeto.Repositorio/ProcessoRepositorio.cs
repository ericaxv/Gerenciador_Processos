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
      public class ProcessoRepositorio
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;

        public void Insert(Processo p)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "Insert into Processo (NumeroProcesso, EstadoExecucao, Valor, Status, DataCriacao, IdCliente)" +
                               " values(@NumeroProcesso, @EstadoExecucao, @Valor, @Status, @DataCriacao, @IdCliente)";

                con.Execute(query, p);
            }
        }

        public List<Processo> FindAll()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "Select * from Processo";

                return con.Query<Processo>(query).ToList();
            }
        }

        public decimal CalcSoma()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "Select sum(Valor) from Processo where Status = 'Ativo'";
                return con.Query(query).Single();
            }
        }
    }
}
