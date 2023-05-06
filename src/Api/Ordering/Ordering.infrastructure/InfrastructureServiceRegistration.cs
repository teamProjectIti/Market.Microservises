using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ordering.Application.Contracts.Infrastructure;
using Ordering.Application.Contracts.Persistence.Generic;
using Ordering.Application.Contracts.Persistence.Order;
using Ordering.Application.Models;
using Ordering.infrastructure.Persistence;
using Ordering.infrastructure.Repositeries;
using Ordering.infrastructure.Repositeries.Mail;
using Ordering.infrastructure.Repositeries.Order;

namespace Ordering.infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
           
            services.AddDbContext<MyContext>(x =>
                 x.UseSqlServer(configuration.GetConnectionString("OrderingConnectionString")));


            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            // services.AddTransient<IEmailService, EmailService>();

            services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
