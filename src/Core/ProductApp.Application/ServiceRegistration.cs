using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProductApp.Application
{
   public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection serviceCollection)
        {
            var assembly = Assembly.GetExecutingAssembly();
            serviceCollection.AddAutoMapper(assembly);
            serviceCollection.AddMediatR(assembly);
        }
    }
}
