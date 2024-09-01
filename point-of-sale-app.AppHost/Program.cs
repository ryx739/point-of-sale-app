var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.point_of_sale_app_Api>("point-of-sale-app-api");

builder.Build().Run();
