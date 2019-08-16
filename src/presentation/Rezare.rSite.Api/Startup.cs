using System;
using System.IO;
using System.Reflection;
using Amazon.DynamoDBv2;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Rezare.rSite.Application.Interfaces;
using Rezare.rSite.Application.UseCases;
using Rezare.rSite.Persistence;
using Rezare.rSite.Persistence.DynamoDb;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Rezare.rSite.Api
{
    /// <summary>
    /// Startup.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// Startup.
        /// </summary>
        /// <param name="configuration">Configuration parameter.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the Startup configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configure Services.
        /// </summary>
        /// <remarks>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </remarks>
        /// <param name="services">Services parameter.</param>
        /// <returns>The autofac Service Provider.</returns>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                     // builder.WithOrigins("http://localhost:4200")
                     //    .AllowAnyHeader()
                     //    .AllowAnyMethod();
                     builder.AllowAnyOrigin()
                         .AllowAnyHeader()
                         .AllowAnyMethod();
                });
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen(GenerateSwaggerOptions);

            services.AddDefaultAWSOptions(Configuration.GetAWSOptions());

            services.AddAWSService<IAmazonDynamoDB>();

            var container = AutoFacContainerBuilder(services);

            return new AutofacServiceProvider(container);
        }

        /// <summary>
        /// Configure.
        /// </summary>
        /// <remarks>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </remarks>
        /// <param name="app">App parameter.</param>
        /// <param name="env">Env parameter.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            if (env.IsDevelopment())
            {
                app.UseCors();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        private void GenerateSwaggerOptions(SwaggerGenOptions options)
        {
            var openApiInfo = new OpenApiInfo
            {
                Title = "r-Site API",
                Version = "v1"
            };

            options.SwaggerDoc("v1", openApiInfo);

            // Set the comments path for the Swagger JSON and UI.
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            options.IncludeXmlComments(xmlPath);
        }

        /// <summary>
        /// Creates an AutoFac ContainerBuilder.
        /// This associated concrete classes with abstract files.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns>AutoFac ContainerBuilder.</returns>
        private IContainer AutoFacContainerBuilder(IServiceCollection services)
        {
            // https://www.dotnetcurry.com/aspnet-core/1426/dependency-injection-di-aspnet-core
            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2
            var containerBuilder = new ContainerBuilder();

            containerBuilder.Populate(services);
            containerBuilder.RegisterType<LinksProvider>().As<ILinksProvider>();
            containerBuilder.RegisterType<Persistence.DynamoDb.LinkRepository>().As<Application.Interfaces.ILinkRepository>();
            containerBuilder.RegisterType<CreateTable>().As<ICreateTable>();
            

            return containerBuilder.Build();
        }
    }
}
