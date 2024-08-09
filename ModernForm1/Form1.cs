using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ModernForm1
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
            this.Width = 1050;
            this.Height = 700;
           
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 2);
        int index;
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color new_color;
        Pen erase = new Pen(Color.White, 17);

        private void btn_color_Click(object sender, EventArgs e)
        {
            index = 2;
            pnlNav.Height = ((Button)sender).Height;
            pnlNav.Left = ((Button)sender).Left;
            pnlNav.Top = ((Button)sender).Top;
            ((Button)sender).BackColor = Color.FromArgb(46, 51, 73);
            cd.ShowDialog();
            new_color = cd.Color;
            pic_Color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
            pnlNav.Height = ((Button)sender).Height;
            pnlNav.Left = ((Button)sender).Left;
            pnlNav.Top = ((Button)sender).Top;
            ((Button)sender).BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
            pnlNav.Height = ((Button)sender).Height;
            pnlNav.Left = ((Button)sender).Left;
            pnlNav.Top = ((Button)sender).Top;
            ((Button)sender).BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = -1;
            pnlNav.Height = ((Button)sender).Height;
            pnlNav.Left = ((Button)sender).Left;
            pnlNav.Top = ((Button)sender).Top;
            ((Button)sender).BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 2;
            pnlNav.Height = ((Button)sender).Height;
            pnlNav.Left = ((Button)sender).Left;
            pnlNav.Top = ((Button)sender).Top;
            ((Button)sender).BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 3;
            pnlNav.Height = ((Button)sender).Height;
            pnlNav.Left = ((Button)sender).Left;
            pnlNav.Top = ((Button)sender).Top;
            ((Button)sender).BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 4;
            pnlNav.Height = ((Button)sender).Height;
            pnlNav.Left = ((Button)sender).Left;
            pnlNav.Top = ((Button)sender).Top;
            ((Button)sender).BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            pnlNav.Height = ((Button)sender).Height;
            pnlNav.Left = ((Button)sender).Left;
            pnlNav.Top = ((Button)sender).Top;
            ((Button)sender).BackColor = Color.FromArgb(46, 51, 73);
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 2)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 3)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }

        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);

            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint == true)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;


                }

                if (index == -1)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;


                }

            }
            pic.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;


            if (index == 2)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 3)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
        }

        bool save = false;
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_Color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_Color.BackColor;
            p.Color = pic_Color.BackColor;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var safff = new SaveFileDialog();
            safff.Filter = "Image(*.png)|*.png|(*.*|*.*";
            if (safff.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(safff.FileName, ImageFormat.Png);

                save = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (save == false)
            {
                DialogResult d = MessageBox.Show("You didnt save the file , Are you sure you want to exit?", "By ImBahmanRanjbar", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (d == DialogResult.No)
                {
                    btn_save_Click(null, null);
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
         
            pnlNav.Height = ((Button)sender).Height;
            pnlNav.Left = ((Button)sender).Left;
            pnlNav.Top = ((Button)sender).Top;
            ((Button)sender).BackColor = Color.FromArgb(46, 51, 73);
         }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(24,30,54);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        private void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr)
                return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);

                }
            }

        }
    }
}
