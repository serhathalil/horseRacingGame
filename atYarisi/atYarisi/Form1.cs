using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsol, ikinciatsol, ucuncuatsol;
        int sure;

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsol = pictureBox1.Left;
            ikinciatsol = pictureBox2.Left;
            ucuncuatsol = pictureBox3.Left;
            btnYeniden.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;
            int bitisuzakligi = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1 numaralı at yarışı önde götürüyor";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 numaralı at iyi bir atakla öne geçti";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3 numaralı at liderliği ele geçirdi";
            }

            if (birinciatgenislik+pictureBox1.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                label6.Text = "1 numaralı at kazandı";
                btnYeniden.Enabled = true;
            }
            if (ikinciatgenislik+pictureBox2.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                label6.Text = "2 numaralı at kazandı";
                btnYeniden.Enabled = true;
            }
            if (ucuncuatgenislik+pictureBox3.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                label6.Text = "3 numaralı at kazandı";
                btnYeniden.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure = Convert.ToInt32(lblSure.Text);
            sure++;
            lblSure.Text = sure.ToString();
        }

        private void btnYeniden_Click(object sender, EventArgs e)
        {
            btnYeniden.Enabled = false;
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            timer2.Enabled = true;
            timer1.Enabled = true;
            sure = 0;
            sure++;
            lblSure.Text = sure.ToString();
            
        }

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
           
        }
    }
}
