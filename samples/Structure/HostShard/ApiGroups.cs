using Microsoft.OpenApi.Models;

namespace Hugin
{
    public static class ApiGroups
    {
        const string ApiVersion = "1.0.0";

        public const string Default = "default";

        public const string Sample = "sample";

        public static readonly ApiInfo DefaultGroup = new ApiInfo
        {
            Name = ApiGroups.Default,
            DisplayName = "Default API",
            OpenApiInfo = new OpenApiInfo
            {
                Version = ApiVersion,
                Title = ApiGroups.Default + " api",
                Description = "框架默认接口"
            }
        };

        public static readonly ApiInfo SampleGroup = new ApiInfo
        {
            Name = ApiGroups.Sample,
            DisplayName = "示例",
            OpenApiInfo = new OpenApiInfo
            {
                Version = ApiVersion,
                Title = ApiGroups.Sample + " api",
                Description = "示例接口"
            }
        };
    }
}
