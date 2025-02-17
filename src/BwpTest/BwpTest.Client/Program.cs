using BlazorWasmProfiler;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

[assembly: MethodTimer]
[assembly: RenderTimer]

var builder = WebAssemblyHostBuilder.CreateDefault(args);

await builder.Build().RunAsync();
