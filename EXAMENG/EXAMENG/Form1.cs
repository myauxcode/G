using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMENG
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
        }


        //borrar
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        public void marco()
        {
            g.DrawRectangle(Pens.Black, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
        }

        //marco
        private void button2_Click(object sender, EventArgs e)
        {

            marco();
            //label1.Text = string.Concat(pictureBox1.Width);
            //label2.Text = string.Concat(pictureBox1.Height);

        }


        //----------------------------------------------------------------------------------------------------------

        //ejercicio 1


        public void ejercicio1(int n)
        {
            float x1, y1, x2, y2;
            float vi1, r1, vi2, my, r2,mx;

            mx = pictureBox1.Width / 2;
            my = pictureBox1.Height / 2;
            vi1 = 0; r1 = mx / n;
            r2 = my / n;    vi2 = my + r2;
            y1 = my;
            x2 = mx;

            g.DrawLine(Pens.Black, 0, my, pictureBox1.Width, my);
            g.DrawLine(Pens.Black, mx, 0,mx, pictureBox1.Height);


            for (int i = 1; i <= n; i++)
            {
                x1 = vi1 + (i - 1) * r1;
                y2 = vi2 + (i - 1) * r2;


                g.DrawLine(Pens.Blue, x1, y1, x2, y2);

            }


        }

        public void ejercicio1_1(int n)
        {
            float x1, y1, x2, y2;
            float vi1, r1, vi2, my, r2, mx;

            mx = pictureBox1.Width / 2;
            my = pictureBox1.Height / 2;
            vi1 = pictureBox1.Width; r1 = mx / n;
            r2 = my / n; vi2 = my + r2;
            y1 = my;
            x2 = mx;

           

            for (int i = 1; i <= n; i++)
            {
                x1 = vi1 + (i - 1) * (-r1);
                y2 = vi2 + (i - 1) * r2;


                g.DrawLine(Pens.Blue, x1, y1, x2, y2);

            }


        }

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
   

            ejercicio1(int.Parse(textBox1.Text));
            ejercicio1_1(int.Parse(textBox1.Text));
        }


        //ejercicio 2

        public void ejer9_9(int n)
        {//inicio

            float x1, y1, x2, y2;
            float mx,mmy,my;
            Boolean ban;
            ban = true;

            Random r = new Random(); //objeto random

            mx = pictureBox1.Width / 2;
            my = pictureBox1.Height / 2;
            mmy = my / 2;

            x1 = r.Next((int)mx, pictureBox1.Width);

            y1 = pictureBox1.Height;

            g.DrawLine(Pens.Black, mx, pictureBox1.Height, mx, 0);
            g.DrawLine(Pens.Black, 0,my, pictureBox1.Width, my);


            for (int i = 1; i <= n; i++)
            {

                x2 = r.Next((int)mx, pictureBox1.Width);

                if (ban == true)
                {
                    y2 = my;
                }
                else
                {
                    y2 = pictureBox1.Height;
                }

                ban = !ban;


                g.DrawLine(Pens.Blue, x1, y1, x2, y2);

                x1 = x2;
                y1 = y2;

            }


        }//fin



        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejer9_9(int.Parse(textBox1.Text));
        }



    }
}
