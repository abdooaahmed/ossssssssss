using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _111111111111111
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();

        }
        public int total {  get; set; }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            

            double Total = total;
            lblgg.Text = "Grade Percentage: " + total.ToString()+"%";
          
            Graphics g = e.Graphics;
            Brush mybrush = new SolidBrush(Color.BlueViolet);

            g.FillRectangle(mybrush, 150, 100, 500, 500);


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
