﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces.Repositories;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence
{
    public static class ServiceRegistrastion
    {
        public static void AddPersistenceService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseInMemoryDatabase("memoryDb");
            });

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
