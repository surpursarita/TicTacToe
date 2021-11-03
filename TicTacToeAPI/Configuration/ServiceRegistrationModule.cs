using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TicTacToe.API.Service.Interface;
using TicTacToe.API.Service.Service;

namespace TicTacToe.API.Configuration
{
    public class ServiceRegistrationModule : Module
    {
        private readonly IConfiguration config;

        public ServiceRegistrationModule(IConfiguration config)
        {
            this.config = config;
        }

        protected override void Load(ContainerBuilder builder)
        {
            RegisterLogger(builder);
            builder.RegisterType<BoardValidateService>().As<IBoardValidateService>().InstancePerLifetimeScope();
            builder.RegisterType<TicTacToeService>().As<ITicTacToeService>().InstancePerLifetimeScope();
        }

        private void RegisterLogger(ContainerBuilder builder)
        {
            builder.Register(c =>
            {
                var logger = c.Resolve<ILogger>();
                return logger;
            }).As<ILogger>().InstancePerLifetimeScope();
        }
    }
}