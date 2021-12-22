using System.Threading.Tasks;

namespace LG.NetCore.Wechat
{
    public interface IWechatDecryptService
    {
        /// <summary>
        /// UserInfo
        /// </summary>
        /// <param name="data">微信数据</param>
        /// <returns></returns>
        Task DecryptUser(string data);

        /// <summary>
        ///  RunInfo
        /// </summary>
        /// <param name="identifier">微信数据关联的标识(比如运动器材的Id)</param>
        /// <param name="data">微信数据</param>
        /// <returns></returns>
        Task DecryptRunData(string identifier, string data);
    }
}
