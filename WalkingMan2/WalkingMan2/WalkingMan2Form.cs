using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WalkingMan2
{
    public partial class frmWalkingMan2 : Form
    {
        public frmWalkingMan2()
        {
            InitializeComponent();

            GenerateBoxes();

        }

        private void GenerateBoxes()
        {
            GenerateBox(12, 12);
            GenerateBox(12, 275);
            GenerateBox(270, 12);
            GenerateBox(270, 275);
        }

        private void GenerateBox(int x, int y)
        {
            PictureBox tmpPbx = new PictureBox();
            Point location = new Point(x, y);

            tmpPbx.Image = Properties.Resources.walk1;
            tmpPbx.Location = location;

            tmpPbx.Size = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            tmpPbx.Click += TmpPbx_Click;

            Controls.Add(tmpPbx);

        }

        async private void TmpPbx_Click(object sender, EventArgs e)
        {
            PictureBox tmpPic = (PictureBox)sender;

            Image walkingman = Properties.Resources.walk1;

            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                        walkingman = Properties.Resources.walk1;
                        break;
                    case 1:
                        walkingman = Properties.Resources.walk2;
                        break;
                    case 2:
                        walkingman = Properties.Resources.walk3;
                        break;
                    case 3:
                        walkingman = Properties.Resources.walk4;
                        break;
                    case 4:
                        walkingman = Properties.Resources.walk5;
                        break;
                    case 5:
                        walkingman = Properties.Resources.walk6;
                        break;
                    case 6:
                        walkingman = Properties.Resources.walk7;
                        break;
                    case 7:
                        walkingman = Properties.Resources.walk8;
                        break;
                    case 8:
                        walkingman = Properties.Resources.walk9;
                        break;
                    case 9:
                        walkingman = Properties.Resources.walk10;
                        break;
                }
                tmpPic.Image = walkingman;

                Refresh();

                Thread.Sleep(50);
            }


        }
    }
}
