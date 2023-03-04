using MarketCenter.Application.Contracts.Infrastructure;
using MarketCenter.Application.Contracts.Persistence;
using MarketCenter.Application.Models;
using MarketCenter.Infrastructure.Mail;
using MarketCenter.Infrastructure.Persistence;
using MarketCenter.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MarketCenter.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MarketCenterContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MarketConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
