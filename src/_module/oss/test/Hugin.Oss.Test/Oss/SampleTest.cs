using LG.NetCore.Oss.Aliyun;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Xunit;

namespace LG.NetCore.Oss
{
    public class SampleTest
    {
        [Fact]
        public void ShouldEquals()
        {
            var services = new ServiceCollection();

            services.AddOss(x =>
            {
                x.Version = "v1.0";
                x.UseAliyun(z =>
                {
                    z.AccessKeyId = "";
                    z.AccessKeySecret = "";
                    z.Endpoint = "";
                    z.BucketName = "";
                });
            });

            var sp = services.BuildServiceProvider();

            var ossOptions = sp.GetRequiredService<IOptions<OssOptions>>();
            //var ossService = sp.GetRequiredService<IOssService>();

            Assert.Equal("v1.0", ossOptions.Value.Version);
            //Assert.NotNull(ossService);
        }
    }
}
