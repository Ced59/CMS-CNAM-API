using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities.CommentairesEntities;
using Entities.DatabasesContext;
using Entities.ExemplesEntitie;
using Microsoft.EntityFrameworkCore;
using Queries;
using Queries.Interface;
using WebAPI.AutoMapperProfiles;
using WebAPI.Helpers;
using Entities.UsersEntities;
using Entities.VariantsEntitie;
using Entities.TagsEntitie;
using Entities.ProduitsEntitie;
using Entities.ImagesEntitie;
using Entities.StocksEntitie;
using Entities.DescriptionsEntitie;

namespace WebAPI
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
            // AutoMapper
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile<ExempleProfile>();
                config.AddProfile<CommentaireProfile>();
                config.AddProfile<UserProfile>();
                config.AddProfile<DescriptionProfile>();
                config.AddProfile<ImageProfile>();
                config.AddProfile<ProduitProfile>();
                config.AddProfile<StockProfile>();
                config.AddProfile<TagProfile>();
                config.AddProfile<VariantProfile>();
            });

            mapperConfig.AssertConfigurationIsValid();

            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            // Ajout des services des différents Cruds
            services.AddScoped<ICrudInterface<Exemple>, ExempleCrudQueryHandler>();
            services.AddScoped<ICrudInterface<Commentaire>, CommentaireCrudQueryHandler>();
            services.AddScoped<ICrudInterface<Variant>, VariantCrudQueryHandler>();
            services.AddScoped<ICrudInterface<Tag>, TagCrudQueryHandler>();
            services.AddScoped<ICrudInterface<Produit>, ProduitCrudQueryHandler>();
            services.AddScoped<ICrudInterface<Image>, ImageCrudQueryHandler>();
            services.AddScoped<ICrudInterface<User>, UserCrudQueryHandler>();



            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CMS CNAM 2022 API", Version = "v0.0.1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "API CNAM CMS 2022"); c.RoutePrefix = "api"; });
            }

            app.UseSwagger();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            // custom jwt auth middleware
            app.UseMiddleware<JwtMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
