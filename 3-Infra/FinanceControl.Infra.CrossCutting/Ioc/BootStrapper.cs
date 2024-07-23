using FinanceControl.Application._1._1_Interface;
using FinanceControl.Application._1._2_AppService;
using FinanceControl.Domain._2._1_Interface;
using FinanceControl.Domain.Notifications;
using FinanceControl.Infra._3._1_Context;
using FinanceControl.Infrastructure._3._3_Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceControl.Infra.CrossCutting.Ioc
{
    public static class BootStrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services) 
        {   
            services.AddScoped<IDomainNotificationHandler, DomainNotificationHandler>();

            services.AddScoped<ILancamentoService, LancamentoService>();
            services.AddScoped<ILancamentoRepository, LancamentoRepository>();
            services.AddScoped<IConsolidacaoService, ConsolidacaoService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<FinanceControlContext>();

            return services;
        }
    }
}
