using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_Component
{
    public partial class QA_Control : UserControl
    {
        private bool radio1, radio2, radio3, radio4;
        private string answer;
        private int score;
        public QA_Control()
        {
            InitializeComponent();
            
        }
      

        public string QuestionLabel
        {
            get { return questionLabel.Text; }
            set { questionLabel.Text= value; }
        }

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public string Option1
        {
            get { return radioButton1.Text; }
            set { radioButton1.Text = value; }
        }
        public string Option2
        {
            get { return radioButton2.Text; }
            set { radioButton2.Text = value; }
        }
        public string Option3
        {
            get { return radioButton3.Text; }
            set { radioButton3.Text = value; }
        }
        public string Option4
        {
            get { return radioButton4.Text; }
            set { radioButton4.Text = value; }
        }



      

        public int Result
        {
            get { return score; }
            set { score = value; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked == true)
            {
                if (Option1 == Answer)
                {
                    score++;
                }
                else
                {
                    score = 0;
                }
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
            if (radioButton2.Checked == true)
            {
                if (Option2 == Answer)
                {
                    score++;
                }
                else
                {
                    score = 0;
                }
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton3.Checked == true)
            {
                if (Option3 == Answer)
                {
                    score++;
                }
                else
                {
                    score = 0;
                }
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButton4.Checked == true)
            {
                if (Option4 == Answer)
                {
                    score++;
                }
                else
                {
                    score = 0;
                }
            }
        }
    }
}
