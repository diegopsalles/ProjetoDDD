using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using AutoMapper;
using Projeto.Application.Mappings;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.WebApi;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Services;
using Projeto.Application.Contracts;
using Projeto.Application.Services;

namespace Projeto.Presentation
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //configurando o AutoMapper
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<EntityToViewModelMap>();
                cfg.AddProfile<ViewModelToEntityMap>();
            });

            //configurando o SimpleInjector
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types, for instance using the scoped lifestyle:
            container.Register<IContatoRepository, ContatoRepository>(Lifestyle.Scoped);
            container.Register<IEnderecoRepository, EnderecoRepository>(Lifestyle.Scoped);
            container.Register<ICompromissoRepository, CompromissoRepository>(Lifestyle.Scoped);

            container.Register<IContatoDomainService, ContatoDomainService>(Lifestyle.Scoped);
            container.Register<IEnderecoDomainService, EnderecoDomainService>(Lifestyle.Scoped);
            container.Register<ICompromissoDomainService, CompromissoDomainService>(Lifestyle.Scoped);

            container.Register<IContatoAppService, ContatoAppService>(Lifestyle.Scoped);
            container.Register<IEnderecoAppService, EnderecoAppService>(Lifestyle.Scoped);
            container.Register<ICompromissoAppService, CompromissoAppService>(Lifestyle.Scoped);

            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

        }
    }
}
