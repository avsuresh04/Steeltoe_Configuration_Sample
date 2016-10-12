using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WWT.StealToe.Configuration.DotNetFramework4_6_1.Startup))]

namespace WWT.StealToe.Configuration.DotNetFramework4_6_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
