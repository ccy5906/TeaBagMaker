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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i < TeaList.Length; i++)
            {
                this.TeaCombo.Items.Add(TeaList[i]);
            }
            this.TeaCombo.SelectedIndex
        }
    }
}
