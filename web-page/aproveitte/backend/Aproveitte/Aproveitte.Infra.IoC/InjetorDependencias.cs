using Aproveitte.Aplicacao.Interfaces;
using Aproveitte.Aplicacao.Serviços;
using Aproveitte.Dominio.Interfaces.Repositorios;
using Aproveitte.Dominio.Interfaces.Servicos;
using Aproveitte.Dominio.Serviços;
using Aproveitte.Infra.Data.Repositórios;
using Microsoft.Extensions.DependencyInjection;

namespace Aproveitte.Infra.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            svcCollection.AddScoped<IReceitaApp, ReceitaApp>();
            svcCollection.AddScoped<IIngredienteApp, IngredienteApp>();
            svcCollection.AddScoped<IUnidadeApp, UnidadeApp>();

            //Domínio
            svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<IReceitaApp, ReceitaApp>();
            svcCollection.AddScoped<IIngredienteApp, IngredienteApp>();
            svcCollection.AddScoped<IUnidadeApp, UnidadeApp>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            svcCollection.AddScoped<IReceitaApp, ReceitaApp>();
            svcCollection.AddScoped<IIngredienteApp, IngredienteApp>();
            svcCollection.AddScoped<IUnidadeApp, UnidadeApp>();
        }
    }
}
