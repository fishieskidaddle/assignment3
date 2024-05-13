using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void home2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void T2Button1_Click(object sender, EventArgs e)
        {
            tsk2label1.Text = "when you're done click 'enter' on your keyboard! ^v^";
        }

        private void f6button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.playerName = f6textBox.Text;
            f7.ShowDialog();
        }
    }
}
