using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeto.Servicos.Models;
using Projeto.Entidades;
using Projeto.Repositorio;

namespace Projeto.Servicos.Controllers
{
    [RoutePrefix("api/processo")]
    public class ProcessoController : ApiController
    {
        [HttpPost]
        [Route("cadastrar")]  // api/processo/cadastrar
        public HttpResponseMessage Cadastrar(ProcessoCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Processo p = new Processo();
                    p.IdCliente = model.IdCliente;
                    p.NumeroProcesso = model.NumeroProcesso;
                    p.EstadoExecucao = model.EstadoExecucao;
                    p.Valor = model.Valor;
                    p.Status = model.Status;
                    p.DataCriacao = model.DataCriacao;


                    ProcessoRepositorio rep = new ProcessoRepositorio();
                    rep.Insert(p);

                    // retorna o status http 200
                    return Request.CreateResponse(HttpStatusCode.OK, "Processo cadastrado com sucesso.");

                }
                catch (Exception e)
                {
                    //retornar o erro do servidor
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Erro: " + e.Message);
                }
            }
            else
            {
                //se os campos informados não estiverem corretos, retorna o erro de validação.
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Erros de validação, gentileza rever os campos informados.");
            }
        }

        [HttpGet]
        [Route("consultar")]  //api/processo/consultar
        public HttpResponseMessage Consultar()
        {

            try
            {
                List<ProcessoConsultaViewModel> lista = new List<ProcessoConsultaViewModel>();
                ProcessoRepositorio rep = new ProcessoRepositorio();
                foreach (Processo p in rep.FindAll())
                {
                    ProcessoConsultaViewModel model = new ProcessoConsultaViewModel();
                    model.IdCliente = p.IdCliente;
                    model.NumeroProcesso = p.NumeroProcesso;
                    model.EstadoExecucao = p.EstadoExecucao;
                    model.Valor = p.Valor;
                    model.Status = p.Status;
                    model.DataCriacao = p.DataCriacao;

                    lista.Add(model);
                }

                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Erro: " + e.Message);
            }


        }

        [HttpGet]
        [Route("teste1")]  //api/processo/teste1
        public HttpResponseMessage CalcularSoma()
        {
            ProcessoRepositorio rep = new ProcessoRepositorio();
            decimal soma = 0;
            soma = rep.CalcSoma();
              
            return Request.CreateResponse(HttpStatusCode.OK, soma);
            
        }
    }
}
