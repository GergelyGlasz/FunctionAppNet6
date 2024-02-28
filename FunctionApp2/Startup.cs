using FunctionApp2;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: FunctionsStartup(typeof(Startup))]
namespace FunctionApp2
{
    public  class Startup : FunctionAppNet6.Startup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            base.Configure(builder);
        }
    }
}
