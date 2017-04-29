using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ElectronicCircles
{
    public partial class TestPage : MetroFramework.Forms.MetroForm
    {
        const int ps = 10;
        const int zs = 15;
        const int tk = 6;
        const int pp = 5;
        const int ns = 3;
        const int mkp = 10;
        private  int[] ans_ps = { 2, 4, 4, 2, 4, 3, 4, 4, 3, 4 };
        private int[] ans_zs = {4,3,3,3,4,4,4,4,1,4,1,4,1,4,2};
        private int[] ans_tk = { 1,2,3,4,4,4 };
        private int[] ans_ns = {3,3,4};
        private int[] ans_pp = { 3, 3, 4 };
        private int[] ans_mkp = {1,4,1,4,4,4,4,4,2,2,1};
        private int[] loader;
        int[] ans_ps_logic = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        int ans_ps_kol = 0;

        private List<Image> list = new List<Image>();
        private Button buttonWasClick;
        private int num = 1;
        private int N1;
 
        public TestPage()
        {
            CallLast.callbackEventHandler = new CallLast.callbackEvent(this.setTheme);
            InitializeComponent();
        }
     
        private void setTheme(string title) {

            if (title == "DC")
            {
                loader = ans_ps;
                setDC();
            } else if (title == "AC")
            {
                loader = ans_zs;
                setAC();
            } else if (title == "FAZ3")
            {
                loader = ans_tk;
                setTK();
            } else if (title == "PP") {
                loader = ans_pp;
                setPP();
            } else if (title == "CNSC") {
                loader = ans_ns;
                setNS();
            } else if (title == "MCAP") {
                loader = ans_mkp;
                setMKP();
            } 
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            question1.Text = num.ToString();
            pictureBox1.Image = Res.DC._1;
        }

        private void setDC() {
            list.Add(Res.DC._1);
            list.Add(Res.DC._2);
            list.Add(Res.DC._3);
            list.Add(Res.DC._4);
            list.Add(Res.DC._5);
            list.Add(Res.DC._6);
            list.Add(Res.DC._7);
            list.Add(Res.DC._8);
            list.Add(Res.DC._9);
            list.Add(Res.DC._10);
            N1 = ps;
            pictureBox1.Image = list[0];
        }
        private void setAC()
        {
            list.Add(Res.AC._1z);
            list.Add(Res.AC._2z);
            list.Add(Res.AC._3z);
            list.Add(Res.AC._4z);
            list.Add(Res.AC._5z);
            list.Add(Res.AC._6z);
            list.Add(Res.AC._7z);
            list.Add(Res.AC._8z);
            list.Add(Res.AC._9z);
            list.Add(Res.AC._10z);
            list.Add(Res.AC._11z);
            list.Add(Res.AC._12z);
            list.Add(Res.AC._13z);
            list.Add(Res.AC._14z);
            list.Add(Res.AC._15z);
            N1 = zs;
            pictureBox1.Image = list[0];

        }
        private void setTK()
        {
            list.Add(Res.TK._1tk);
            list.Add(Res.TK._2tk);
            list.Add(Res.TK._3tk);
            list.Add(Res.TK._4tk);
            list.Add(Res.TK._5tk);
            list.Add(Res.TK._6tk);
            N1 = tk;
            pictureBox1.Image = list[0];

        }
        private void setPP()
        {
            list.Add(Res.PP._1pp);
            list.Add(Res.PP._2pp);
            list.Add(Res.PP._3pp);
            list.Add(Res.PP._4pp);
            list.Add(Res.PP._5pp);
            N1 = pp;
            pictureBox1.Image = list[0];

        }
        private void setNS()
        {
            list.Add(Res.NS._1ns);
            list.Add(Res.NS._2ns);
            list.Add(Res.NS._3ns);
            N1 = ns;
            pictureBox1.Image = list[0];
        }
        private void setMKP()
        {
            list.Add(Res.MKP._1mk);
            list.Add(Res.MKP._2mk);
            list.Add(Res.MKP._3mk);
            list.Add(Res.MKP._4mk);
            list.Add(Res.MKP._5mk);
            list.Add(Res.MKP._6mk);
            list.Add(Res.MKP._7mk);
            list.Add(Res.MKP._8mk);
            list.Add(Res.MKP._9mk);
            list.Add(Res.MKP._10mk);
            N1 = mkp;
            pictureBox1.Image = list[0];

        }
        private void ans3_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
                if (num > 1)
                {
                    num--;
                    question1.Text = num.ToString();
                    pictureBox1.Image = list[num - 1];
                    //circularPB1.Value = (int)((N1/num) * 10);

                }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (num < N1)
            {
                ++num;
                setBut();
                question1.Text = num.ToString();
                pictureBox1.Image = list[num-1];
                //circularPB1.Value = (int)((N1/num) * 10);
            }
        }
        // Загрузка форми
        private void TestPage_Load(object sender, EventArgs e)
        {
            
        }
        // Дати відповідь
        //////
        private void ans1_Click(object sender, EventArgs e)
        {
            buttonWasClick = (Button)sender;
            guess(1,buttonWasClick);
        }

        private void ans2_Click(object sender, EventArgs e)
        {
            buttonWasClick = (Button)sender;
            guess(2,buttonWasClick);
        }
        // Якби 3тя кнопка
        private void metroButton4_Click(object sender, EventArgs e)
        {
            buttonWasClick = (Button)sender;
            guess(3,buttonWasClick);
        }

        private void ans4_Click(object sender, EventArgs e)
        {
            buttonWasClick = (Button)sender;
            guess(4,buttonWasClick);
        }

        private void ans5_Click(object sender, EventArgs e)
        {
            buttonWasClick = (Button)sender;
            guess(5,buttonWasClick);
        }
        /////
        private void guess(int buttonNumber,Button answerButton) {

            if (loader[num-1] == buttonNumber)
            {
                ans_ps_kol++;
                ans_ps_logic[num - 1]++;
                ans1.Enabled = false;
                ans2.Enabled = false;
                ans3.Enabled = false;
                ans4.Enabled = false;
                ans5.Enabled = false;
                answerButton.BackColor = Color.Blue;

            }
            else
            {
                ans_ps_logic[num - 1]--;
                answerButton.BackColor = Color.Red;
            }
        }
        private void setBut() {
            ans1.Enabled = true;
            ans2.Enabled = true;
            ans3.Enabled = true;
            ans4.Enabled = true;
            ans5.Enabled = true;
        }
    }

    public static class CallLast
    {
        public delegate void callbackEvent(string title);
        public static callbackEvent callbackEventHandler;
    }
}
