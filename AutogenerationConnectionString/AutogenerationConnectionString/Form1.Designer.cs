namespace AutogenerationConnectionString
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbox_databaseType = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_orcl = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_Ip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_readFile = new System.Windows.Forms.Button();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.txt_encryptInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_connInfo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.cmbox_databaseType);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.txt_orcl);
            this.groupBox1.Controls.Add(this.txt_port);
            this.groupBox1.Controls.Add(this.txt_Ip);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库连接配置";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 20);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(320, 231);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "测试连接";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmbox_databaseType
            // 
            this.cmbox_databaseType.FormattingEnabled = true;
            this.cmbox_databaseType.Items.AddRange(new object[] {
            "Oracle",
            "SQL Server",
            "MySQL"});
            this.cmbox_databaseType.Location = new System.Drawing.Point(144, 35);
            this.cmbox_databaseType.Name = "cmbox_databaseType";
            this.cmbox_databaseType.Size = new System.Drawing.Size(229, 20);
            this.cmbox_databaseType.TabIndex = 24;
            this.cmbox_databaseType.SelectedIndexChanged += new System.EventHandler(this.cmbox_databaseType_SelectedIndexChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(278, 261);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(144, 261);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "生成";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(144, 207);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(229, 21);
            this.txt_password.TabIndex = 11;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(144, 166);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(229, 21);
            this.txt_UserName.TabIndex = 10;
            // 
            // txt_orcl
            // 
            this.txt_orcl.Location = new System.Drawing.Point(144, 134);
            this.txt_orcl.Name = "txt_orcl";
            this.txt_orcl.Size = new System.Drawing.Size(229, 21);
            this.txt_orcl.TabIndex = 9;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(144, 95);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(229, 21);
            this.txt_port.TabIndex = 8;
            // 
            // txt_Ip
            // 
            this.txt_Ip.Location = new System.Drawing.Point(144, 68);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Size = new System.Drawing.Size(229, 21);
            this.txt_Ip.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(74, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "  密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(74, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "登录名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(26, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "服务名称(ORCL)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(74, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "  端口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "服务器主机地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库类型：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_readFile);
            this.groupBox2.Controls.Add(this.btn_saveFile);
            this.groupBox2.Controls.Add(this.txt_encryptInfo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_connInfo);
            this.groupBox2.Location = new System.Drawing.Point(436, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btn_readFile
            // 
            this.btn_readFile.Location = new System.Drawing.Point(214, 261);
            this.btn_readFile.Name = "btn_readFile";
            this.btn_readFile.Size = new System.Drawing.Size(121, 23);
            this.btn_readFile.TabIndex = 23;
            this.btn_readFile.Text = "读取文件信息";
            this.btn_readFile.UseVisualStyleBackColor = true;
            this.btn_readFile.Click += new System.EventHandler(this.btn_readFile_Click);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.Location = new System.Drawing.Point(93, 261);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(75, 23);
            this.btn_saveFile.TabIndex = 22;
            this.btn_saveFile.Text = "保存文件";
            this.btn_saveFile.UseVisualStyleBackColor = true;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // txt_encryptInfo
            // 
            this.txt_encryptInfo.Location = new System.Drawing.Point(93, 134);
            this.txt_encryptInfo.Multiline = true;
            this.txt_encryptInfo.Name = "txt_encryptInfo";
            this.txt_encryptInfo.Size = new System.Drawing.Size(242, 107);
            this.txt_encryptInfo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "加密信息：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "连接信息：";
            // 
            // txt_connInfo
            // 
            this.txt_connInfo.Location = new System.Drawing.Point(93, 22);
            this.txt_connInfo.Multiline = true;
            this.txt_connInfo.Name = "txt_connInfo";
            this.txt_connInfo.Size = new System.Drawing.Size(242, 94);
            this.txt_connInfo.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 146);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Token";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 71);
            this.textBox1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "Token ：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(493, 20);
            this.comboBox2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "选择用户：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 316);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "是否启用生成token工具";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 336);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "自动生成连接字符串";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_orcl;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_Ip;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_saveFile;
        private System.Windows.Forms.TextBox txt_encryptInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_connInfo;
        private System.Windows.Forms.Button btn_readFile;
        private System.Windows.Forms.ComboBox cmbox_databaseType;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

