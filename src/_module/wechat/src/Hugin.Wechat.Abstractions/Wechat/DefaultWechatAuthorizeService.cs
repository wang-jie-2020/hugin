using System.Threading.Tasks;

namespace LG.NetCore.Wechat
{
    /// <summary>
    /// 不实现任何业务，只是待替换的中间过程
    /// </summary>
    public class DefaultWechatAuthorizeService : IWechatAuthorizeService
    {
        public async Task<string> Authorize(string openId, string phone = null)
        {
            return await Task.FromResult(string.Empty);
        }
    }
}
