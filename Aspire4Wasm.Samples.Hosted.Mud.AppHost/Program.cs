var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.Aspire4Wasm_Samples_Hosted_Mud_WebApi>("api");

var blazorHost = builder.AddProject<Projects.Aspire4Wasm_Samples_Hosted_Mud_UI_Server>("blazorHost");
blazorHost.AddWebAssemblyClient<Projects.Aspire4Wasm_Samples_Hosted_Mud_UI_Client>("blazorClient")
    .WithReference(api);

api.WithReference(blazorHost);

builder.Build().Run();
