using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            int top = 0, left = 0;
            // [,] diziyi iki boyutlu yapıyor. 0-1 şeklinde ulaşabiliriz.
            Button[,] button1 = new Button[8, 8];
            // getupper ilgili boyutun en fazla alabileceği değer oda virgilün sol tarafı oluyor.
            for (int i = 0; i < button1.GetUpperBound(0); i++)
            {
                for (int j = 0; j < button1.GetUpperBound(1); j++)
                {
                    button1[i, j] = new Button();
                    button1[i, j].Height = 50;
                    button1[i, j].Width = 50;
                    button1[i, j].Left = left;
                    button1[i, j].Top = top;
                    left = left + 50;
                    this.Controls.Add(button1[i, j]);
                    if ((i + j) % 2 == 0)
                    {
                        button1[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        button1[i, j].BackColor = Color.White;
                    }
                }
                left = 0;
                top = top + 50;
            }
        }
    }
}
