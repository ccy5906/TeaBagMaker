using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] TeaList = new string[] { "홍차(2분)", "녹차(3분)", "루이보스차(5분)", "국화차(2분)" };
        int teaName = 0;
        int CountOrgNum = 0;
        int min, sec;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < TeaList.Length; i++)
            {
                this.TeaCombo.Items.Add(TeaList[i]);
            }
            this.TeaCombo.SelectedIndex = 0;
        }

        private void But_add_Click(object sender, EventArgs e)
        {
            if (this.TeaCombo.SelectedIndex == 0)
            {
                teaName = 0;
                CountOrgNum = 120;
            }
            else if(this.TeaCombo.SelectedIndex == 1)
            {
                teaName = 1;
                CountOrgNum = 180;
            }
            else if (this.TeaCombo.SelectedIndex == 2)
            {
                teaName = 2;
                CountOrgNum = 300;
            }
            else if (this.TeaCombo.SelectedIndex == 3)
            {
                teaName = 3;
                CountOrgNum = 120;
            }
            this.timer.Enabled = true;
        }

        private void ButOK_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
            this.Countdown.Text = "";
            this.TeaCombo.Focus();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(this.CountOrgNum < 1)
            {
                this.timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                this.TeaCombo.Focus();
                this.Countdown.Text = "";
            }
            else
            {
                this.CountOrgNum--;
                
                min = CountOrgNum / 60;
                sec = CountOrgNum % 60;
                if (min == 0)
                {
                    this.Countdown.Text = Convert.ToString( sec + "초 남았습니다!");
                }
                else
                {
                    this.Countdown.Text = Convert.ToString(min + "분 " + sec + "초 남았습니다!");
                }
                
               //this.Countdown.Text = Convert.ToString(CountOrgNum);

            }
        }
    }
}
