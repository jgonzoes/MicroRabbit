using MicroRabbit.Banco.Aplication.Services;
using MicroRabbit.Banco.Data.Context;
using MicroRabbit.Banco.Data.Repository;
using MicroRabbit.Banco.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegistarServices(IServiceCollection services)
        {
            //Domanin Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Aplication Services
            services.AddTransient<AccountService, AccountService>();

            //
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContex>();
        }
    }
}
