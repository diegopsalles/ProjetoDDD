using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeto.Application.ViewModels;
using Projeto.Application.Contracts;

namespace Projeto.Presentation.Controllers
{
    [RoutePrefix("api/Contato")] //ENDPOINT
    public class ContatoController : ApiController
    {
        //atributo
        private readonly IContatoAppService appService;

        //construtor para injeção de dependência
        public ContatoController(IContatoAppService appService)
        {
            this.appService = appService;
        }

        [HttpPost]
        public HttpResponseMessage Post(ContatoCadastroViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    appService.Cadastrar(model);
                    return Request.CreateResponse
                        (HttpStatusCode.OK, "Contato cadastrado com sucesso.");
                }
                catch(Exception e)
                {
                    return Request.CreateResponse
                        (HttpStatusCode.InternalServerError, e.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
