using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int[] linia = new int[5];
        int[] tree_Ugl = new int[7];
        int[] elips = new int[5];
        int[] prymo_Ugl = new int[9];
        int[] toch = new int[3];
        int[] kv = new int[5];
        int[] dyga = new int[7];
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "линия")
            {
                linia[1] = Convert.ToInt32(textBox1.Text);
                linia[2] = Convert.ToInt32(textBox2.Text);
                linia[3] = Convert.ToInt32(textBox3.Text);
                linia[4] = Convert.ToInt32(textBox4.Text);
                pictureBox1.Refresh ();
             
            }
            if (comboBox1.Text == "треугольник")
            {
                tree_Ugl[1] = Convert.ToInt32(textBox1.Text);
                tree_Ugl[2] = Convert.ToInt32(textBox4.Text);
                tree_Ugl[3] = Convert.ToInt32(textBox2.Text);
                tree_Ugl[4] = Convert.ToInt32(textBox5.Text);
                tree_Ugl[5] = Convert.ToInt32(textBox3.Text);
                tree_Ugl[6] = Convert.ToInt32(textBox6.Text);
                index = 1;
                pictureBox1.Refresh();
            }
            if (comboBox1.Text == "элипс")
            {
                index = 1;
                elips[1] = Convert.ToInt32(textBox1.Text);
                elips[2] = Convert.ToInt32(textBox2.Text);
                elips[3] = Convert.ToInt32(textBox3.Text);
                elips[4] = Convert.ToInt32(textBox4.Text);
                pictureBox1.Refresh();

            }
            if (comboBox1.Text == "прямоугольник")
            {
                index = 1;
                prymo_Ugl[1] = Convert.ToInt32(textBox1.Text);
                prymo_Ugl[2] = Convert.ToInt32(textBox2.Text);
                prymo_Ugl[3] = Convert.ToInt32(textBox3.Text);
                prymo_Ugl[4] = Convert.ToInt32(textBox4.Text);
                pictureBox1.Refresh();

            }
            if (comboBox1.Text == "точка")
            {
                index = 1;
                toch[1] = Convert.ToInt32(textBox1.Text);
                toch[2] = Convert.ToInt32(textBox2.Text);
            }
            if (comboBox1.Text == "квадрат")
            {  
                if (textBox1.Text != textBox3.Text && textBox2.Text != textBox4.Text && textBox2.Text !=textBox3.Text && textBox1.Text !=textBox4.Text) 
                {
                    MessageBox.Show("введенные значения должны совпадать", "Ошибка",MessageBoxButtons.YesNo,MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    pictureBox1.Image = null;
                }
                else
                {
                    index = 1;
                    kv[1] = Convert.ToInt32(textBox1.Text);
                    kv[2] = Convert.ToInt32(textBox2.Text);
                    kv[3] = Convert.ToInt32(textBox3.Text);
                    kv[4] = Convert.ToInt32(textBox4.Text);
                    pictureBox1.Refresh();
                }
            }
            if (comboBox1.Text == "дуга")
            { 
                index = 1;
                dyga[1] = Convert.ToInt32(textBox1.Text);
                dyga[2] = Convert.ToInt32(textBox2.Text);
                dyga[3] = Convert.ToInt32(textBox3.Text);
                dyga[4] = Convert.ToInt32(textBox4.Text);
                dyga[5] = Convert.ToInt32(textBox6.Text);
                dyga[6] = Convert.ToInt32(textBox5.Text);
                pictureBox1.Refresh();
            }

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(System.Drawing.Pens.Green, linia[1], linia[2], linia[3], linia[4]);
            if (index == 1)
            {
                e.Graphics.DrawLine(System.Drawing.Pens.Black, tree_Ugl[1], tree_Ugl[2], tree_Ugl[3], tree_Ugl[4]);
                e.Graphics.DrawLine(System.Drawing.Pens.Black, tree_Ugl[3], tree_Ugl[4], tree_Ugl[5], tree_Ugl[6]);
                e.Graphics.DrawLine(System.Drawing.Pens.Black, tree_Ugl[5], tree_Ugl[6], tree_Ugl[1], tree_Ugl[2]);
            } 
            if (index == 1)
            {
                Pen Перо = new Pen(Color.Black);
                e.Graphics.DrawEllipse(Перо, elips[1], elips[2], elips[3], elips[4]);
            }
            e.Graphics.DrawRectangle(System.Drawing.Pens.Black, prymo_Ugl[1], prymo_Ugl[2], prymo_Ugl[3], prymo_Ugl[4]);
            e.Graphics.DrawLine(System.Drawing.Pens.Black, toch[1], toch[2], 0, 0);
            e.Graphics.DrawRectangle(System.Drawing.Pens.Black, kv[1], kv[2], kv[3], kv[4]);
            e.Graphics.DrawArc(Pens.Black, dyga[1], dyga[2], dyga[3], dyga[4], dyga[5], dyga[6]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "линия")
            {
                label8.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
            if (comboBox1.Text == "точка")
            {
                label3.Visible = false;
                label4.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                label8.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
            if (comboBox1.Text == "треугольник")
            {
                label8.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                label7.Visible = true;
                label10.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
            if (comboBox1.Text == "элипс")
            {
                label8.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
            if (comboBox1.Text == "прямоугольник")
            {
                label8.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
            if (comboBox1.Text== "квадрат")
            {
                label8.Visible = false;
                textBox6.Visible = false;
                textBox5.Visible = false;
                label7.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
            if (comboBox1.Text == "дуга")
            {
                label8.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                label7.Visible = true;
                label10.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }


    }
}



