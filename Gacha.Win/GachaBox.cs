using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gacha.Win
{
    public partial class cbxGachaBox : Form
    {
        public cbxGachaBox()
        {
            InitializeComponent();
        }
        private GachaCore core = new GachaCore();
        private void btnOneTime_Click(object sender, EventArgs e)
        {
            string rare = core.TakeGacha();
            if (core.gachaCount == 0) {
                rare = core.TakeGacha("SSR");
            }
            MessageBox.Show("本次抽卡结果：" + rare + "\n"
                + "离必出SSR还剩" + core.gachaCount + "次"
                , "结果", MessageBoxButtons.OK);
        }

        private void btnTenGacha_Click(object sender, EventArgs e)
        {
            string[] gachaResult = new string[10];
            int guarantCount = 0;//十连保底计数
            for(int i = 0; i < 10;i++) {
                gachaResult[i] = core.TakeGacha();
                if (core.gachaCount == 0) {
                    gachaResult[i] = core.TakeGacha("SSR");
                }
                if (gachaResult[i] == "R") {
                    guarantCount++;
                }
            }

            if(guarantCount == 10) {
                gachaResult[9] = core.TakeGacha("SR");
            }
            
            string rare = string.Join(" ", gachaResult);

            MessageBox.Show("本次抽卡结果：" + rare + "\n"
                + "离必出SSR还剩" + core.gachaCount + "次"
                , "结果", MessageBoxButtons.OK);
        }

        private void cbxGachaBox_Load(object sender, EventArgs e)
        {
            /*try
            {
                string filepath = string.Format("{0}Gacha.db", Application.StartupPath);
                if (!System.IO.File.Exists(filepath))
                {
                    MessageBox.Show("数据库文件不存在");
                }
                string connstring = string.Format("Data Source={0};", filepath);
                Microsoft.Data.Sqlite.SqliteConnection conn = new Microsoft.Data.Sqlite.SqliteConnection(connstring);
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("数据库连接测试成功");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            cbxSettings setting = new cbxSettings();
            setting.ShowDialog();
        }
    }
}
