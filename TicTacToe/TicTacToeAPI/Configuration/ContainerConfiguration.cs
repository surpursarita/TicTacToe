using Autofac;
using Microsoft.Extensions.Configuration;

namespace TicTacToe.API.Configuration
{
    internal class ContainerConfiguration
    {
        public static void Register(IConfiguration config, ContainerBuilder builder)
        {
            builder.RegisterModule(new ServiceRegistrationModule(config));
        }
    }
}
