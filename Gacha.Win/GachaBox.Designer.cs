namespace Gacha.Win
{
    partial class cbxGachaBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titel = new System.Windows.Forms.Label();
            this.btnOneTime = new System.Windows.Forms.Button();
            this.btnTenGacha = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titel.Location = new System.Drawing.Point(90, 63);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(640, 88);
            this.Titel.TabIndex = 0;
            this.Titel.Text = "这是一个抽卡模拟器";
            // 
            // btnOneTime
            // 
            this.btnOneTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOneTime.Location = new System.Drawing.Point(90, 262);
            this.btnOneTime.Name = "btnOneTime";
            this.btnOneTime.Size = new System.Drawing.Size(220, 117);
            this.btnOneTime.TabIndex = 1;
            this.btnOneTime.Text = "一次抽卡";
            this.btnOneTime.UseVisualStyleBackColor = true;
            this.btnOneTime.Click += new System.EventHandler(this.btnOneTime_Click);
            // 
            // btnTenGacha
            // 
            this.btnTenGacha.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTenGacha.Location = new System.Drawing.Point(521, 262);
            this.btnTenGacha.Name = "btnTenGacha";
            this.btnTenGacha.Size = new System.Drawing.Size(209, 117);
            this.btnTenGacha.TabIndex = 2;
            this.btnTenGacha.Text = "十连抽卡";
            this.btnTenGacha.UseVisualStyleBackColor = true;
            this.btnTenGacha.Click += new System.EventHandler(this.btnTenGacha_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(694, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(94, 29);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "抽卡设置";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cbxGachaBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnTenGacha);
            this.Controls.Add(this.btnOneTime);
            this.Controls.Add(this.Titel);
            this.Name = "cbxGachaBox";
            this.Text = "抽卡模拟器";
            this.Load += new System.EventHandler(this.cbxGachaBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Button btnOneTime;
        private System.Windows.Forms.Button btnTenGacha;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Button btnSettings;
    }
}