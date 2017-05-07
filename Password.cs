using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicCircles
{
    public partial class Password : MetroFramework.Forms.MetroForm
    {
        public Password()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (pass.Text.ToString() == "O4ko")
            {
                DevelopPage dev = new DevelopPage();
                dev.Show();
                Close();
            }
            else MetroFramework.MetroMessageBox.Show(this, "Некорректний пароль");
        }

        private void click() {
            MetroFramework.MetroMessageBox.Show(this, "Некорректний пароль");
        }
    }
}
