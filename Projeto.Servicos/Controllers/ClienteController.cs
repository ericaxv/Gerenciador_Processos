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
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        [HttpPost]
        [Route("cadastrar")]  // api/cliente/cadastrar
        public HttpResponseMessage Cadastrar(ClienteCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Cliente c = new Cliente();
                    c.Nome = model.Nome;
                    c.Cnpj = model.Cnpj;
                    c.Localizacao = model.Localizacao;

                    ClienteRepositorio rep = new ClienteRepositorio();
                    rep.Insert(c);

                    // retorna o status http 200
                    return Request.CreateResponse(HttpStatusCode.OK, "Cliente cadastrado com sucesso.");

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
        [Route("consultar")]  // api/cliente/consultar
        public HttpResponseMessage Consultar()
        {

            try
            {
                List<ClienteConsultaViewModel> lista = new List<ClienteConsultaViewModel>();
                ClienteRepositorio rep = new ClienteRepositorio();
                foreach(Cliente c in rep.FindAll())
                {
                    ClienteConsultaViewModel model = new ClienteConsultaViewModel();
                    model.IdCliente = c.IdCliente;
                    model.Nome = c.Nome;
                    model.Cnpj = c.Cnpj;
                    model.Localizacao = c.Localizacao;

                    lista.Add(model);
                }

                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Erro: " + e.Message);
            }


        }
    }
}
