using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameStrategy.Controller
{
    public class CameraController
    {
        private readonly Panel parentPanel;
        private Point mouseDown;

        public CameraController(Panel panel)
        {
            parentPanel = panel;
            AssigneEvent(panel);
        }

        private void AssigneEvent(Control control)
        {
            control.MouseDown += MouseDown;
            control.MouseMove += MouseMove;
            foreach (Control child in control.Controls) AssigneEvent(child);
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            var pointDiff = new Point(Cursor.Position.X - mouseDown.X, Cursor.Position.Y - mouseDown.Y);
            if (mouseDown.X == Cursor.Position.X && mouseDown.Y == Cursor.Position.Y)
                return;
            ;
            var currsorAutoScroll = parentPanel.AutoScrollPosition;
            parentPanel.AutoScrollPosition = new Point(Math.Abs(currsorAutoScroll.X) - pointDiff.X,
                Math.Abs(currsorAutoScroll.Y) - pointDiff.Y);
            mouseDown = Cursor.Position;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mouseDown = Cursor.Position;
        }
    }
}