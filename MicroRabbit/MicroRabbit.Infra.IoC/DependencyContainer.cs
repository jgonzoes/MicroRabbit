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

        }
    }
}
