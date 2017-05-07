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
    public partial class TestResult : MetroFramework.Forms.MetroForm
    {
        public TestResult()
        {
            CallResult.callbackEventHandler = new CallResult.callbackEvent(this.setProgresResult);
            InitializeComponent();
        }

        private void setProgresResult(int numberQuestion,int numberAnswered) {
            int precent = (int) (numberAnswered * 100) / numberQuestion;
            circularPB1.Value = precent;
            resultat.Text = "Ви набрали " + numberAnswered + " із " + numberQuestion + " балів";
        }
    }

    public static class CallResult
    {
        public delegate void callbackEvent(int numnberOfQuestion ,int numberAnswered);
        public static callbackEvent callbackEventHandler;
    }
}
