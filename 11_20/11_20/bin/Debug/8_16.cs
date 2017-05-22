using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_16
{
    public partial class MakeRectangle : Form
    {
        private Point[] vertices = { new Point(20, 280), new Point(280, 280), new Point(280, 20), new Point(20, 20) };
        private GraphicsPath p = new GraphicsPath();
        private Region region;
        private int oldX = 100;
        private int oldY = 75;
        private bool inside = false;
        private int count = 0;

        public MakeRectangle()
        {
            InitializeComponent();
            Size = new Size(300, 300);
            Text = "Make Rectangle";
            BackColor = Color.White;
            p.AddPolygon(vertices);
            region = new Region(p);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (count < 1)
            {
                
            }
            else if(count > 0)
            {
                Graphics g = e.Graphics;
                g.FillRegion(Brushes.Blue, region);
            }
            base.OnPaint(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (region.GetBounds(CreateGraphics()).Contains(e.X, e.Y))
            {
                count++;
                oldX = e.X;
                oldY = e.Y;
                inside = true;
                Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (region.GetBounds(CreateGraphics()).Contains(e.X, e.Y))
            {
                count = 0;
                oldX = e.X;
                oldY = e.Y;
                inside = true;
                Invalidate();
            }
        } 

        public static void main()
        {
            Application.Run(new MakeRectangle());
        }
    }
}
