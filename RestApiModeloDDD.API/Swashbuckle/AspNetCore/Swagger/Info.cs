using Microsoft.OpenApi.Models;

namespace Swashbuckle.AspNetCore.Swagger
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}