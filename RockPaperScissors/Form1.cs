using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        string[] OutS = new string[]
        {
            "じゃん",
            "けん",
            "ぽん",
        };
        string Input = "";
        List<string> Type = new List<string>()
        {
            "グー",
            "チョキ",
            "パー",
        };
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count == 3)
            {
                if (Input != "")
                {
                    int i = R.Next(3);
                    label1.Text = Type[i];
                    bool? result = WinLose(Input,i);
                    if (result== null)
                    {
                        label2.Text = "あいこ";

                    }
                    else if ((bool)result)
                    {
                        label2.Text = "勝ち";
                    }
                    else
                    {
                        label2.Text = "負け";

                    }
                }
                else
                {
                    label2.Text = "後だし";
                }
                count = 0;
                button4.Enabled = true;
                timer1.Stop();
            }
            else
            {
                label2.Text = OutS[count];
            }
            count++;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Input = "";

            button4.Enabled = false;
            count = 0;
            timer1.Start();
        }
        Random R = new Random();
        bool? WinLose(string Input,int input2)
        {
            if (Type[input2] == Input)
            {
                return null;
            }
            else
            {
                ;
                int index = Type.IndexOf(Input);
                if ((index+1 == input2)|| (index == 2 && input2== 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input=((Button)sender).Text;
            label3.Text = Input;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
