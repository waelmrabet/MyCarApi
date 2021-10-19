using BLL.ServicePattern;
using BLL.Services;
using BLL.Services.Impl;
using Data;
using Data.Pattern;
using Data.Repositories;
using Data.Repositories.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Root
{
    public static class CompositionRoot
    {        
        public static void InjectServices(IServiceCollection services, string connectionString)
        {            
            #region // databases injection

            services.AddDbContext<MyDataBaseContext>(opts => opts.UseSqlServer(connectionString, b => b.MigrationsAssembly("Data")));
            services.AddScoped<MyDataBaseContext>();

            #endregion

            #region // RepositoryPattern && ServicePattern 
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IServicePattern<>), typeof(ServicePattern<>));
            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IInterventionRepository, InterventionRepository>();
            services.AddScoped<IVehiculeRepository, VehiculeRepository>();

            #endregion

            #region Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IInterventionService, InterventionService>();
            services.AddScoped<IVehiculeService, VehiculeService>();

            #endregion

        }
    }
}
