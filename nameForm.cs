using MaterialSkin.Controls;
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
    public partial class nameForm : MetroFramework.Forms.MetroForm
    {
        private string middleSender;
        public nameForm()
        {
            Call.callbackEventHandler = new Call.callbackEvent(this.LoadTitle);
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void LoadTitle(string title)
        {
            middleSender = title;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            onClickButton();
        }

        private void nameForm_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter)
            {
                onClickButton();
            }
        }

        private void onClickButton() {
            string name = inputName.Text.ToString();
            string misha = "Красний";
            string yura = "Митуля";
            string ruslan = "Вийгшев";
            if (name.IndexOf(misha) > -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Красний??А я червений!!!Хахахаха!!!", "Червений");
            }
            if (name.IndexOf(yura) > -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "НЕВИЦЬКИЙ???", "ОК");
            }
            if (name.IndexOf(ruslan) > -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Вийгшев - вийшов!", "ОК");
                //Application.Exit();
            }
            if (String.IsNullOrEmpty(name))
            {
                MetroFramework.MetroMessageBox.Show(this, "Введіть будь ласка ім'я!", "Помилка вводу");
                nameForm formAgain = new nameForm();
                formAgain.Show();
            }
            else
            {
                
                CallBack.callbackEventHandler(inputName.Text.ToString());
                TestPage test = new TestPage();
                test.Show();
                CallLast.callbackEventHandler(middleSender);
            }
            Close();
        }

        private void nameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CallBack.callbackEventHandler(inputName.Text.ToString());
        }
    }
    public static class Call
    {
        public delegate void callbackEvent(string title);
        public static callbackEvent callbackEventHandler;
    }

}
