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
        public int counting = 0;
        private void btnOneTime_Click(object sender, EventArgs e)
        {
            int gachaResult = -1;
            int basicRate = 0;
            Random rare = new Random();
            gachaResult = rare.Next(0, 100);
            if (counting >= 50)
            {
                basicRate = counting - 50;
            }
            if (gachaResult >= 0 && gachaResult < basicRate)
            {
                basicRate++;
                MessageBox.Show("你抽中了 SSR 1张\n" +
                    "这一次抽到SSR的概率为" + basicRate + "%", "结果");
                counting = 0;
                basicRate--;
            }
            else if (gachaResult >= basicRate && gachaResult <= 5 + basicRate)
            {
                basicRate++;
                MessageBox.Show("你抽中了 SR 1张\n" +
                    "这一次抽到SSR的概率为" + basicRate + "%", "结果");
                basicRate--;
            }
            else
            {
                basicRate++;
                MessageBox.Show("你抽中了 R 1张\n" +
                    "这一次抽到SSR的概率为" + basicRate + "%", "结果");
                basicRate--;
            }
            counting++;
        }

        private void btnTenGacha_Click(object sender, EventArgs e)
        {
            int[] gachaResult = new int[10];
            int SSR = 0, SR = 0, R = 0;
            for (int i = 0; i < 10; i++)
            {
                int basicRate = 0;
                Random random = new Random();
                gachaResult[i] = random.Next(0, 100);
                if (counting >= 50)
                {
                    basicRate = counting - 50;
                }
                if (gachaResult[i] >= 0 && gachaResult[i] <= basicRate)
                {
                    SSR++;
                    counting = 0;
                }
                else if (gachaResult[i] > basicRate && gachaResult[i] < basicRate + 5)
                {
                    SR++;
                }
                else
                {
                    R++;
                }
            }
            
            if (SSR == 0 && SR == 0)
            {
                Random random = new Random();
                gachaResult[9] = random.Next(0, 100);
                if (gachaResult[9] == 0)
                {
                    SSR++;
                }
                else if (gachaResult[9] >= 1 && gachaResult[9] < 100)
                {
                    SR++;
                }
                R--;
            }

            MessageBox.Show("你抽到了 SSR " + SSR + "张\n" +
                "你抽到了 SR" + SR + "张\n" +
                "你抽到了 R" + R + "张", "提示");
            counting += 10;
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
    }
}
