using Microsoft.OpenApi.Models;

namespace HostShared
{
    public static class ApiGroups
    {
        const string ApiVersion = "1.0.0";

        public const string Default = "default";

        public const string Platform = "platform";

        public const string Terminal = "terminal";

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

        public static readonly ApiInfo PlatformGroup = new ApiInfo
        {
            Name = ApiGroups.Platform,
            DisplayName = "平台 API",
            OpenApiInfo = new OpenApiInfo
            {
                Version = ApiVersion,
                Title = ApiGroups.Platform + " api",
                Description = "平台接口"
            }
        };

        public static readonly ApiInfo TerminalGroup = new ApiInfo
        {
            Name = ApiGroups.Terminal,
            DisplayName = "终端 API",
            OpenApiInfo = new OpenApiInfo
            {
                Version = ApiVersion,
                Title = ApiGroups.Terminal + " api",
                Description = "终端接口"
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
