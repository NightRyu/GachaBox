using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gacha.Win {
    public partial class cbxSettings : Form {
        public cbxSettings() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
