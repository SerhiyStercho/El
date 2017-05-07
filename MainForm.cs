using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace ElectronicCircles
{
    [Serializable]
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public string D_C = "DC";
        public string A_C = "AC";
        public string FAZ3 = "FAZ3";
        public string PP = "PP";
        public string CNSC = "CNSC";
        public string MCAP = "MCAP";
        public int nameWindowActive;
        public string student;
        // Стартовий
        public Main()
        {
            CallBack.callbackEventHandler = new CallBack.callbackEvent(this.Reload);
           // Thread load = new Thread(new ThreadStart(Loading));
           // load.Start();
            InitializeComponent();
           
           /* for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(5);
            }
            try
            {
                load.Abort();
            }
            catch (ThreadAbortException e)
            {
                Thread.ResetAbort();
            }*/
        }

     
       
       /* public void Loading() {
            frmSplashScreen frame = new frmSplashScreen();
            try
            {
                Application.Run(frame);
            }
            catch (ThreadAbortException e)
            {
                Thread.ResetAbort();
            }
         
        }*/
        void Reload(string param)
        {
            nameofstudent.Text = "Тест проходить: " +param;
            free();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver;

        }

        public void call() {
            nameForm name = new nameForm();
            name.Owner = this;
            name.Show();
        }
        //постійний струм
        private void metroButton1_Click(object sender, EventArgs e)
        {
            free_ornot();
            call();
            Call.callbackEventHandler(D_C);

        }
        //змінний струм
        private void metroButton2_Click(object sender, EventArgs e)
        {
            free_ornot();
            call();
            Call.callbackEventHandler(A_C);
        }

        //перехідні процеси
        private void metroButton3_Click(object sender, EventArgs e)
        {
            free_ornot();
            call();
            Call.callbackEventHandler(PP);
        }

        //3 фазні кола
        private void metroButton4_Click(object sender, EventArgs e)
        {
            free_ornot();
            call();
            Call.callbackEventHandler(FAZ3);
        }
      
        //кола несинусоїдального струму
        private void metroButton5_Click(object sender, EventArgs e)
        {
            free_ornot();
            call();
            Call.callbackEventHandler(CNSC);
        }
        //магнітні кола та пристрої
        private void metroButton6_Click(object sender, EventArgs e)
        {
            
            call();
            Call.callbackEventHandler(MCAP);
            free_ornot();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Ця програма написана для тестування студентів ІТФ УжНУ, з дисципліни, Теорія електричних та магнітних кіл. Розроблена студентами 2-го курсу ІТФ УжНУ КІ 2017.Автор ідеї - Славік Володимир Миколайович,Розробка та дизайн - Стерчо Сергій Михайлович,Розробка - Козарь Ярослав Віталійович,Підказки - Кондратюк Владислав Сергійович, Пєздюк - Кіс Володимир ", "Про програму");
        }

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void free_ornot()
        {
            metroButton1.Enabled = false;
            metroButton2.Enabled = false;
            metroButton3.Enabled = false;
            metroButton4.Enabled = false;
            metroButton5.Enabled = false;
            metroButton6.Enabled = false;
            
        }
        public void free()
        {
            metroButton1.Enabled = true;
            metroButton2.Enabled = true;
            metroButton3.Enabled = true;
            metroButton4.Enabled = true;
            metroButton5.Enabled = true;
            metroButton6.Enabled = true;
        }

        private void сторінкаРозробникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password pass = new Password();
            pass.Show();
        }

        private void гловкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }

    public static class CallBack
    {
        public delegate void callbackEvent(string what);
        public static callbackEvent callbackEventHandler;
    }
}
