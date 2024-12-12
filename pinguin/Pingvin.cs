using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pinguin
{
    class Pingvin:UserControl
    {
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;

        public string name { get; private set; }
        public int age { get; set; }

        public Pingvin(string name,int age)
        {
            InitializeComponent();
            if (name.Length > 0)
            {
                this.name = name;
            }
            else
            {
                throw new Exception("nincs neve a pinguin");
            }
            this.age = age;
            label1.Text += name;
            label2.Text += age;
            button1.Click += pingvinHello;
        }

        void pingvinHello(object s,EventArgs e)
        {
            MessageBox.Show($"Szia,{name} vagyok");
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nev ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Koszonje";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kor ";
            // 
            // Pingvin
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Pingvin";
            this.Size = new System.Drawing.Size(377, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
