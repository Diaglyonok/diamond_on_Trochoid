using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Color color;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawBox.BackColor = Color.White;
            num_of_graphics.Items.AddRange(new object[]{"1", "2", "3", "4", "5", "6"});
            
        }

        private void button_draw_Click_1(object sender, EventArgs e)
        {
            color = Color.FromArgb(Convert.ToInt32(R_color.Text), Convert.ToInt32(G_color.Text), Convert.ToInt32(B_color.Text));
            FuncSetts setts = new FuncSetts(Convert.ToInt32(a_tag.Text), Convert.ToInt32(b_tag.Text), Convert.ToSingle(step.Text));
            Drawer drawer = new Drawer(drawBox, Convert.ToInt32(diam_heigth.Text), Convert.ToInt32(diam_width.Text), setts, Convert.ToInt32(num_of_graphics.Text), color);
            drawer.DrawFuncByStep();

        }
    }
}
