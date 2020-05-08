using Aproveitte.Aplicacao;
using Aproveitte.Infra.Data.Contextos;
using Aproveitte.Infra.IoC;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace Aproveitte.Servicos.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            //services.AddControllers();
            services.AddDbContext<Contexto>(o => o.UseMySql(Configuration.GetConnectionString("Aproveitte")));
            InjetorDependencias.Registrar(services);
            services.AddAutoMapper(typeof(MappingEntidade).Assembly);

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                string caminhoAplicacao = PlatformServices.Default.Application.ApplicationBasePath;
                string nomeAplicacao = PlatformServices.Default.Application.ApplicationName;
                string caminhoDocumentacao = Path.Combine(caminhoAplicacao, $"{nomeAplicacao}.xml");
                c.IncludeXmlComments(caminhoDocumentacao);

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Aproveitte", Version = "v1" });

            });
            #endregion

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(a => a.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            
            //app.UseMvc();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            #region configurações do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");

            });
            #endregion
        }
    }
}
