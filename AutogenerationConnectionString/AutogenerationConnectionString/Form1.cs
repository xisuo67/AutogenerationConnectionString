using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutogenerationConnectionString
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private static List<UserInfo> UserInfoList = new List<UserInfo>();
        /// <summary>
        /// 生成连接信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            string con = txt_connInfo.Text.Trim();
            string conn = string.Empty;
            if (string.IsNullOrEmpty(con))
            {
                SelectEnum select = (SelectEnum)cmbox_databaseType.SelectedIndex;
                DataSource dataSource = GetDataSource(select, e);
                if (dataSource == null)
                {
                    return;
                }
                conn = dataSource.GetConnection();
                txt_connInfo.Text = conn;
            }
            else
            {
                conn = con;
            }
            txt_encryptInfo.Text = DESEncrypt.Encrypt(conn);
        }
        private DataSource GetDataSource(SelectEnum select, EventArgs e)
        {

            DataSource dataSource = null;
            string conn = string.Empty;
            bool hasEmpty = false;
            var Ip = txt_Ip.Text.Trim();//主机地址
            hasEmpty = BeforeSubmit(Ip, "主机地址");
            if (hasEmpty) return dataSource;
            var port = txt_port.Text.Trim();//端口
            var orcl = txt_orcl.Text.Trim();//orcl
            var databaseName = comboBox1.Text;//数据库名称
            var UserName = txt_UserName.Text.Trim();//用户名
            hasEmpty = BeforeSubmit(UserName, "用户名");
            if (hasEmpty) return dataSource;
            var password = txt_password.Text.Trim();//密码
            hasEmpty = BeforeSubmit(password, "密码");
            if (hasEmpty) return dataSource;
            switch (select)
            {
                case SelectEnum.Oracle:
                    hasEmpty = BeforeSubmit(port, "端口");
                    if (hasEmpty) return dataSource;
                    hasEmpty = BeforeSubmit(orcl, "服务名称");
                    if (hasEmpty) return dataSource;
                    dataSource = new DataSource()
                    {
                        DataBaseType = (int)SelectEnum.Oracle,
                        ServerName = Ip,
                        Port = Convert.ToInt32(port),
                        Password = password,
                        UserName = UserName,
                        DataBaseName = orcl
                    };
                    break;
                case SelectEnum.Server_SQL:
                    var link = e as LinkLabelLinkClickedEventArgs;
                    if (link == null)
                    {
                        hasEmpty = BeforeSubmit(databaseName, "数据库名称");
                        if (hasEmpty) return dataSource;
                    }
                    dataSource = new DataSource()
                    {
                        DataBaseType = (int)SelectEnum.Server_SQL,
                        ServerName = Ip,
                        Password = password,
                        UserName = UserName,
                        DataBaseName = databaseName
                    };
                    break;
                case SelectEnum.MySQL:
                    var links = e as LinkLabelLinkClickedEventArgs;
                    if (links==null)
                    {
                        hasEmpty = BeforeSubmit(databaseName, "数据库名称");
                        if (hasEmpty) return dataSource;
                    }
                    dataSource = new DataSource()
                    {
                        DataBaseType = (int)SelectEnum.MySQL,
                        ServerName = Ip,
                        Port = Convert.ToInt32(port),
                        Password = password,
                        UserName = UserName,
                        DataBaseName = databaseName
                    };
                    break;
                default:
                    break;
            }
            return dataSource;
        }
        /// <summary>
        /// 提交前效验
        /// </summary>
        /// <param name="item">检查对象</param>
        /// <param name="message">对象名称</param>
        private bool BeforeSubmit(string item, string message)
        {
            bool hasEmpty = string.IsNullOrEmpty(item);
            if (hasEmpty)
            {
                MessageBox.Show($"{message}不能为空");
            }
            return hasEmpty;
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbox_databaseType.SelectedIndex = 0;
        }
        /// <summary>
        /// 数据库类型改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbox_databaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectIndex = cmbox_databaseType.SelectedIndex;
            SelectEnum index = (SelectEnum)selectIndex;
            ShowOrHide(index);
        }
        /// <summary>
        /// 根据枚举值隐藏或显示控件
        /// </summary>
        /// <param name="index">枚举值</param>
        private void ShowOrHide(SelectEnum index)
        {
            switch (index)
            {
                case SelectEnum.Oracle:
                    label4.Text = "服务名称(ORCL)：";
                    txt_port.Visible = true;
                    comboBox1.Visible = false;
                    txt_orcl.Visible = true;
                    label3.Visible = true;
                    comboBox1.Text = "";
                    break;
                case SelectEnum.Server_SQL:
                    //label3.Text = "数据库：";
                    label3.Visible = false;
                    label4.Text = "        数据库："; //隐藏orcl
                    txt_orcl.Visible = false;//隐藏文本框
                    txt_port.Visible = false;
                    comboBox1.Visible = true;
                    break;
                case SelectEnum.MySQL:
                    //label3.Visible = false;
                    label4.Text = "        数据库："; //隐藏orcl
                    txt_orcl.Visible = false;//隐藏文本框
                    //txt_port.Visible = false;
                    comboBox1.Visible = true;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 将连接字符串生成config文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_encryptInfo.Text))
            {
                MessageBox.Show(this, "请先生成加密连接字符串", "提示");
                return;
            }
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择本地连接文件存放的文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
            }
            string connectionString = $"<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<configuration>\r\n<add key = \"DefaultConnection\" value=\"{ txt_encryptInfo.Text }\"/>\r\n</configuration>";
            string path = $"{dialog.SelectedPath}/Config_local.config";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs); // 创建写入流
            sw.WriteLine(connectionString); // 写入连接信息
            sw.Close();
            MessageBox.Show(this, "连接文件生成成功", "提示");

        }

        private void btn_readFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.config)|*.config";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string connection = string.Empty;
                string filePath = fileDialog.FileName;
                StreamReader srReadFile = new StreamReader(filePath, Encoding.Default);
                while (!srReadFile.EndOfStream)  //读取流直至文件末尾结束
                {
                    string strRead = srReadFile.ReadToEnd(); //读取所有数据
                    connection += strRead;
                }
                srReadFile.Close(); // 关闭读取流文件
                connection = Regex.Match(connection, "(?<=value=\").*?(?=\")").Value;
                txt_encryptInfo.Text = connection;
                string conn = DESEncrypt.Decrypt(connection);
                txt_connInfo.Text = conn;
                string reg = "DATA SOURCE=";
                bool checkDatabase = Regex.IsMatch(conn, reg);
                int index = 0;
                if (checkDatabase)
                {
                    index = 0;
                }
                else
                {
                    reg = "server=";
                    checkDatabase = Regex.IsMatch(conn, reg);
                    if (checkDatabase)
                    {
                        index = 1;
                    }
                    else
                    {
                        index = 2;
                    }
                }
                cmbox_databaseType.SelectedIndex = index;
                SelectEnum select = (SelectEnum)index;
                switch (select)
                {
                    case SelectEnum.Oracle:
                        txt_Ip.Text = Regex.Match(conn, "(?<=DATA SOURCE=).*?(?=:)").Value;
                        txt_port.Text = Regex.Match(conn, "(?<=:).*?(?=/)").Value;
                        txt_orcl.Text = Regex.Match(conn, "(?<=/).*?(?=;)").Value;
                        txt_password.Text = Regex.Match(conn, "(?<=PASSWORD=).*?(?=;)").Value;
                        txt_UserName.Text = Regex.Match(conn, "(?<=USER ID=).*?(.*)").Value;
                        break;
                    case SelectEnum.Server_SQL:
                        txt_Ip.Text = Regex.Match(conn, "(?<=server=).*?(?=;)").Value;
                        txt_password.Text = Regex.Match(conn, "(?<=pwd=).*?(?=;)").Value;
                        txt_UserName.Text = Regex.Match(conn, "(?<=uid=).*?(?=;)").Value;
                        comboBox1.Text = Regex.Match(conn, "(?<=database=).*?(.*)").Value;
                        break;
                    case SelectEnum.MySQL:
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// linkLable点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectEnum select = (SelectEnum)cmbox_databaseType.SelectedIndex;
            DataSource ds = GetDataSource(select, e);
            if (ds == null)
            {
                return;
            }
            switch (select)
            {
                case SelectEnum.Oracle:
                    using (OracleConnection con = new OracleConnection(ds.GetConnection()))
                    {
                        try
                        {
                            con.Open();
                            OracleCommand cmd = con.CreateCommand();
                            cmd.CommandText = "select 1 from dual";
                            OracleDataAdapter da = new OracleDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt != null)
                            {
                                MessageBox.Show(this, "连接成功", "提示");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "数据库连接失败", "提示");
                        }
                    }
                    break;
                case SelectEnum.Server_SQL:
                    using (SqlConnection con = new SqlConnection(string.Format("server={0};uid={1};pwd={2};database=master", ds.ServerName, ds.UserName, ds.Password)))
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "SELECT name FROM sys.databases WHERE name NOT IN ('master','model','msdb','tempdb','ReportServer','ReportServerTempDB','AdventureWorks','AdventureWorksDW') ORDER BY name ";
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            var dataSource = dt;
                            if (dataSource != null)
                            {
                                MessageBox.Show(this, "连接成功", "提示");
                            }
                            comboBox1.DataSource = dataSource;
                            comboBox1.DisplayMember = "name";
                            comboBox1.SelectedIndex = 0;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "数据库连接失败", "提示");
                        }

                    }
                    break;
                case SelectEnum.MySQL:
                    using (MySqlConnection con =new MySqlConnection($"Data Source={ds.ServerName};Port={ds.Port};Database=information_schema;User Id={ds.UserName};Password={ds.Password};Charset=utf8;SslMode=none"))
                    {
                        try
                        {
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "select SCHEMA_NAME as name from information_schema.SCHEMATA";
                            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            var dataSource = dt;
                            if (dataSource != null)
                            {
                                MessageBox.Show(this, "连接成功", "提示");
                            }
                            comboBox1.DataSource = dataSource;
                            comboBox1.DisplayMember = "name";
                            comboBox1.SelectedIndex = 0;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "数据库连接失败", "提示");
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_connInfo.Text = "";
            txt_encryptInfo.Text = "";
            txt_Ip.Text = "";
            txt_orcl.Text = "";
            txt_password.Text = "";
            txt_port.Text = "";
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userName = comboBox2.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("请先选择要生成token的用户名");
                return;
            }
            var entity = UserInfoList.FirstOrDefault(x=>x.UserName==userName);
            if (entity!=null)
            {
                string token = JsonConvert.SerializeObject(new UserToken(entity.UserGuid));
                textBox1.Text= DESEncrypt.Encrypt(token);
            }
            else
            {
                MessageBox.Show("生成失败");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (string.IsNullOrEmpty(txt_connInfo.Text))
                {
                    MessageBox.Show("请先输入连接信息","提示");
                    return;
                }
                this.Height = 530;
                SelectEnum select = (SelectEnum)cmbox_databaseType.SelectedIndex;
                string connection = txt_connInfo.Text.Trim();
                //DataSource ds = GetDataSource(select, e);
                switch (select)
                {
                    case SelectEnum.Oracle:
                        using (OracleConnection con = new OracleConnection(connection))
                        {
                            try
                            {
                                con.Open();
                                OracleCommand cmd = con.CreateCommand();
                                cmd.CommandText = "select UserGuid,UserCode as UserName from SYS_USER";
                                OracleDataAdapter da = new OracleDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                if (dt != null)
                                {
                                    UserInfoList = dt.ToList<UserInfo>();
                                    comboBox2.DataSource = dt;
                                    comboBox2.DisplayMember = "UserName";
                                    comboBox2.SelectedIndex = 0;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(this, "数据库连接失败", "提示");
                            }
                        }
                        break;
                    case SelectEnum.Server_SQL:
                        break;
                    case SelectEnum.MySQL:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                this.Height = 375;
            }
        }
    }
}
