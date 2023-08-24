using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI.CustomControls
{
    internal class HexagonControl :  UserControl
{
    public HexagonControl()
    {
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        SetStyle(ControlStyles.ResizeRedraw, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        GraphicsPath path = new GraphicsPath();
        int width = ClientSize.Width;
        int height = ClientSize.Height;

        Point[] points = new Point[6];
        points[0] = new Point(width / 4, 0);
        points[1] = new Point(3 * width / 4, 0);
        points[2] = new Point(width, height / 2);
        points[3] = new Point(3 * width / 4, height);
        points[4] = new Point(width / 4, height);
        points[5] = new Point(0, height / 2);

        path.AddPolygon(points);

        this.Region = new Region(path);

        using (SolidBrush brush = new SolidBrush(BackColor))
        {
            e.Graphics.FillPath(brush, path);
        }

        base.OnPaint(e);
    }
}
}



