using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pinguin
{
    public partial class Form1 : Form
    {
        List<Pingvin> allpingiun = new List<Pingvin>();
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        void Start()
        {
            button1.Click += ButtonClick;
        }

        void ButtonClick(object s,EventArgs e)
        {
            try
            {
                Pingvin onepingvin = new Pingvin(textBox1.Text, int.Parse(textBox2.Text));
                groupBox2.Controls.Add(onepingvin);
                onepingvin.Top = onepingvin.Height * allpingiun.Count;
                allpingiun.Add(onepingvin);
               
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
