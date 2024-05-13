using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace task_3
{
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }

        private void home1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void T1Button1_Click(object sender, EventArgs e)
        {
            tsk1label1.Text = "well.. first we gotta tell the computer to actually WRITE something.. :p";
        }

        private void tsk1btntrue_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = this.Location;
            f3.Show();
            this.Hide();

            SoundPlayer splayer = new SoundPlayer(@"C:\Users\8060329\Downloads\meow.wav");
            splayer.Play();
        }

        private void tsk1btnfalse1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.StartPosition = FormStartPosition.Manual;
            f4.Location = this.Location;
            f4.Show();
            this.Hide();
        }

        private void tsk1btnfalse2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.StartPosition = FormStartPosition.Manual;
            f5.Location = this.Location;
            f5.Show();
            this.Hide();
        }
    }
}
