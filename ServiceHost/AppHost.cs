using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack;
using Funq;
using ServiceStack.Configuration;
namespace ServiceHost
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Configure your ServiceStack AppHost singleton instance:
        /// Call base constructor with App Name and assembly where Service classes are located
        /// </summary>
        public AppHost()
            : base("hostService", typeof(HostService).GetAssembly())
        {
            AppSettings = new MultiAppSettings(
                new EnvironmentVariableSettings(),
                new AppSettings());
        }

        public override void Configure(Container container)
        {

        }

    }
}
