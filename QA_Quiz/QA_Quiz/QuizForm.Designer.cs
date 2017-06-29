namespace QA_Quiz
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.qA_Control1 = new QA_Component.QA_Control();
            this.qA_Control2 = new QA_Component.QA_Control();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(885, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit your Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 53);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.qA_Control1);
            this.flowLayoutPanel1.Controls.Add(this.qA_Control2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(885, 462);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // qA_Control1
            // 
            this.qA_Control1.Answer = "using";
            this.qA_Control1.BackColor = System.Drawing.Color.Gray;
            this.qA_Control1.Location = new System.Drawing.Point(3, 3);
            this.qA_Control1.Name = "qA_Control1";
            this.qA_Control1.Option1 = "imports";
            this.qA_Control1.Option2 = "using";
            this.qA_Control1.Option3 = "exports";
            this.qA_Control1.Option4 = "None of the above.";
            this.qA_Control1.QuestionLabel = "Which of the following keyword is used for including the namespaces in the progra" +
    "m in C#?";
           
            this.qA_Control1.Result = 0;
            this.qA_Control1.Size = new System.Drawing.Size(648, 400);
            this.qA_Control1.TabIndex = 0;
            // 
            // qA_Control2
            // 
            this.qA_Control2.Answer = "IEnumerable";
            this.qA_Control2.BackColor = System.Drawing.Color.Gray;
            this.qA_Control2.Location = new System.Drawing.Point(3, 409);
            this.qA_Control2.Name = "qA_Control2";
            this.qA_Control2.Option1 = "IList";
            this.qA_Control2.Option2 = "ICollection";
            this.qA_Control2.Option3 = "IEnumerable";
            this.qA_Control2.Option4 = "IComparer";
            this.qA_Control2.QuestionLabel = "Which of the following interfaces should be implemented to use LINQ to Objects?";
            
            this.qA_Control2.Result = 0;
            this.qA_Control2.Size = new System.Drawing.Size(648, 400);
            this.qA_Control2.TabIndex = 1;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 515);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private QA_Component.QA_Control qA_Control1;
        private QA_Component.QA_Control qA_Control2;
    }
}