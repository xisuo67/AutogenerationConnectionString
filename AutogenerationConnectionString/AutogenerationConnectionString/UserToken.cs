using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutogenerationConnectionString
{
    /// <summary>
    /// 用户认证令牌
    /// </summary>
    public class UserToken
    {
        /// <summary>
        /// 当前用户
        /// </summary>
        public string UserGUID { get; set; }

        /// <summary>
        /// 分配的密钥key
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// 令牌生成时间
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="UserGUID">当前用户</param>
        public UserToken(string UserGUID, string AppKey)
        {
            this.UserGUID = UserGUID;
            Time = DateTime.Now;
            this.AppKey = AppKey;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="UserGUID">当前用户</param>
        public UserToken(string UserGUID)
        {
            this.UserGUID = UserGUID;
            //Time = DateTime.Now;
        }

        public UserToken()
        {
        }
    }
}
