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
using System.Threading;
// МЕГА МОЩНИЙ СУПЕР КОД!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// Попередження("Держиться усьо на соплях!Прохання не трогати")
/// <summary>
/// Створений 02.05.2017
/// Розробники:
/// 1) Сегргій Стерчо
/// 2) Яросляв Козарь
/// </summary>
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
        private int[] ans_ps = { 2, 4, 4, 2, 4, 3, 4, 4, 3, 4 };//добре
        private int[] ans_zs = {4,3,3,3,4,4,4,4,1,4,1,4,1,4,2};//добре
        private int[] ans_tk = { 1,2,3,4,4,4 };//добре
        private int[] ans_ns = {3,3,4};//35 добре
        private int[] ans_pp = { 4, 4, 2,4,4 };//good
        private int[] ans_mkp = {1,4,1,4,4,4,4,4,2,2}; //good
        private int[] loader;
        private int ans_kol = 0;
        private List<Button> answerButtons = new List<Button>();
        private List<Image> list = new List<Image>();
        private int num = 1;
        private int wrong = 0;
        private int right = 0;
        private int N1;
        SaveButton save = new SaveButton();
        public TestPage()
        {
            CallLast.callbackEventHandler = new CallLast.callbackEvent(this.setTheme);
            InitializeComponent();
            answerButtons.Add(ans1);
            answerButtons.Add(ans2);
            answerButtons.Add(ans3);
            answerButtons.Add(ans4);
            answerButtons.Add(ans5);
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

        private void reloadButtons(bool[] arrayOfButton)
        {
            for (int i = 0; i < answerButtons.Count; i++) {
                answerButtons[i].Enabled = arrayOfButton[i];
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
           
            guess(1, (Button)sender);
        }

        private void ans2_Click(object sender, EventArgs e)
        {
            guess(2, (Button)sender);
        }
        // Якби 3тя кнопка
        private void metroButton4_Click(object sender, EventArgs e)
        {
            guess(3, (Button)sender);
        }

        private void ans4_Click(object sender, EventArgs e)
        {
            guess(4, (Button)sender);
        }

        private void ans5_Click(object sender, EventArgs e)
        {
            guess(5,(Button)sender);
        }
        //////////
        private void guess(int buttonNumber,Button answerButton) {
            ans_kol++;
            if (loader[num-1] == buttonNumber)
            {
                
                right++;
                right_answer.Text = right.ToString();
                for (int i = 0; i < (answerButtons.Count); i++) {
                    //if (i != buttonNumber - 1) {
                        answerButtons[i].Enabled = false;
                    //}
                }
                save.addButton(ans1.Enabled, ans2.Enabled, ans3.Enabled, ans4.Enabled, ans5.Enabled);
                //answerButton.BackColor = Color.Blue;
                incQuestion();
            }
            else
            {
                wrong++;
                wrong_answer.Text = wrong.ToString();
                for (int i = 0; i < (answerButtons.Count); i++)
                {
                    //if (i != buttonNumber-1)
                    //{
                        answerButtons[i].Enabled = false;
                    //}
                }
                save.addButton(ans1.Enabled, ans2.Enabled, ans3.Enabled, ans4.Enabled, ans5.Enabled);
                incQuestion();
                //answerButton.BackColor = Color.Red;
            }
        }
        ////////////////////////
        private void incQuestion() {
            for (int i=0;i<60;i++) {
                try
                {
                    Thread.Sleep(5);
                }
                catch { }
            }
            //enableNext();
            if (num < N1)
            {
                ++num;
                question1.Text = num.ToString();
                pictureBox1.Image = list[num - 1];
                //if (num <= save.one.Count) return;
                setBut();

            }
            if ((right+wrong) == N1) {
                TestResult result = new TestResult();
                result.Show();
                CallResult.callbackEventHandler(N1,right);
            }
        }

        private void enableNext() {
            if (num > save.one.Count-1) {
                next.Enabled = false;
            }
            else if (num == save.one.Capacity-1) { next.Enabled = true; }
        }
        ////////////////////////
        ////////////////////////
        ////////////////////////
        ////////////////////////
        private void setBut() {
                ans1.Enabled = true;
                ans2.Enabled = true;
                ans3.Enabled = true;
                ans4.Enabled = true;
                ans5.Enabled = true;
            
        }

        private void TestPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ans_kol != loader.Length  && ans_kol<loader.Length) {
                MetroFramework.MetroMessageBox.Show(this,"У вас залишилось "+(loader.Length-ans_kol)+" питань.Ви дійсно хочете завершити тест?","Вихід");
                save.cleanList();
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void exitTest_Click(object sender, EventArgs e)
        {
            TestResult result = new TestResult();
            result.Show();
            CallResult.callbackEventHandler(N1, right);
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (ans1.Enabled==true) { return; }
            if (num < N1)
            {
                ++num;
                //enableNext();
                question1.Text = num.ToString();
                pictureBox1.Image = list[num - 1];
                if (num <= save.one.Count) return;
                setBut();

            }
        }

        private void backnew2_Click(object sender, EventArgs e)
        {
            if (num > 1)
            {
                num--;
                question1.Text = num.ToString();
                pictureBox1.Image = list[num - 1];
                save.addIndex(num - 1);
                reloadButtons(save.getArrayOfBool());
               // enableNext();
                //next.Enabled = true;
            }
        }
    }

    public static class CallLast
    {
        public delegate void callbackEvent(string title);
        public static callbackEvent callbackEventHandler;
    }
}
