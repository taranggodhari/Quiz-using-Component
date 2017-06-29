using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QA_Component;
namespace QA_Quiz
{
    public partial class QuizForm : Form
    {
        
        public QuizForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int Result;
            Result = qA_Control1.Result + qA_Control2.Result;
            if (MessageBox.Show("Your Final Score is:  " + Result.ToString(), "Final Score", MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK)
                Result = 0;

            MessageBox.Show("Correct answer For Question 1 is " + qA_Control1.Answer + "\nCorrect answer For Question 2 is " + qA_Control2.Answer);

        }

        
    }
}
