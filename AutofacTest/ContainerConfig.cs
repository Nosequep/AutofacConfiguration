using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutofacTest.Data;
using AutofacTest.Services;
using Microsoft.EntityFrameworkCore;
using ILogger = AutofacTest.Services.ILogger;

namespace AutofacTest
{
    public class ContainerConfig : Module
    {
        private readonly IServiceCollection _services;
        private readonly ConfigurationManager _configurationManager;

        public ContainerConfig(IServiceCollection services, ConfigurationManager configurationManager)
        {
            _services = services;
            _configurationManager = configurationManager;
        }

        protected override void Load(ContainerBuilder builder)
        {
            //_services.AddDbContext<DbModel>(options => options.UseSqlite(_configurationManager.GetConnectionString("Default")));

            //Add the services to autofac
            //builder.Populate(_services);

            builder.RegisterType<LoggerDefault>().As<ILogger>();
            builder.RegisterType<UserService>().As<IUserService>();

 
        }
    }
}
