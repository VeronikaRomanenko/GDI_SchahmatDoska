using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_SchahmatDoska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int h = this.ClientSize.Height / 8;
            int w = this.ClientSize.Width / 8;
            Graphics graphics = e.Graphics;
            bool belij;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            belij = true;
                        }
                        else
                        {
                            belij = false;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            belij = false;
                        }
                        else
                        {
                            belij = true;
                        }
                    }
                    if (belij)
                    {
                        graphics.FillRectangle(Brushes.White, w * j, h * i, w, h);
                    }
                    else
                    {
                        graphics.FillRectangle(Brushes.Black, w * j, h * i, w, h);
                    }
                }
            }
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}