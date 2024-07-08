var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Mod_Plkn_Web_AppServer>("mod-plkn-web-appserver");

builder.AddProject<Projects.Mod_Plkn_Web_ApiServer>("mod-plkn-web-apiserver");

builder.Build().Run();
