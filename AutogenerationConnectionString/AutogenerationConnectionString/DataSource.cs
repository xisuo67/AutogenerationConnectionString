using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutogenerationConnectionString
{
    public class DataSource
    {
        public string GetConnection()
        {
            SelectEnum select = (SelectEnum)DataBaseType;
            string con = string.Empty;
            switch (select)
            {
                case SelectEnum.Oracle:
                    con = string.Format("DATA SOURCE={2}:{3}/{4}; PASSWORD={0};PERSIST SECURITY INFO = True; USER ID={1}", Password, UserName, ServerName, Port, DataBaseName);
                    break;
                case SelectEnum.Server_SQL:
                    con = string.Format("server={0};uid={1};pwd={2};database={3}", ServerName, UserName, Password, DataBaseName);
                    break;
                case SelectEnum.MySQL:
                    con = $"Data Source={ServerName};Port={Port};Database={DataBaseName};User Id={UserName};Password={Password};Charset=utf8;SslMode=none";
                    break;
                default:
                    break;
            }
            return con;
        }

        /// <summary>
        /// 数据库类型 0:Oracle 1：SQL Server
        /// </summary>
        public int DataBaseType { get; set; }

        /// <summary>
        /// 服务器IP
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// 服务器端口
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Oracle数据库名称
        /// </summary>
        public string OracleDataBaseName { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DataBaseName { get; set; }
    }
}
