using System.Threading.Tasks;

namespace LG.NetCore.Wechat
{
    /// <summary>
    /// 不实现任何业务，只是待替换的中间过程
    /// </summary>
    public class DefaultWechatDecryptService : IWechatDecryptService
    {
        public async Task DecryptUser(string data)
        {
            await Task.CompletedTask;
        }

        public async Task DecryptRunData(string identifier, string data)
        {
            await Task.CompletedTask;
        }
    }
}
