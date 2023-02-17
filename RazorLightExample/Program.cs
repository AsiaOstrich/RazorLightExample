using RazorLight;
using System.Reflection;

// ...

var engine = new RazorLightEngineBuilder()
    .UseEmbeddedResourcesProject(Assembly.GetExecutingAssembly())
    .UseMemoryCachingProvider()
    .Build();

//var templateKey = "Namespace.Path.To.Template.cshtml";
var templateKey = "RazorLightExample.EmailTemplates.Body.cshtml";
var model = new
{
    Title = "Hello, RazorLight!",
    Items = new List<string> {
        "Item 1",
        "Item 2",
        "Item 3"
    }
};

string result = await engine.CompileRenderAsync(templateKey, model);

Console.WriteLine(result);