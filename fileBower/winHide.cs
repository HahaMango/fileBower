using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace fileBower
{
    class WinHide
    {
        private double Sx = SystemParameters.PrimaryScreenWidth;
        private double Sy = SystemParameters.PrimaryScreenHeight;
        private Window win;
        public WinHide(Window win)
        {
            this.win = win;
        }
        public void Start()
        {
            this.win.MouseLeftButtonUp += Win_MouseLeftButtonUp;
            this.win.MouseEnter += Win_MouseEnter;
            this.win.MouseLeave += Win_MouseLeave;
        }

        private void Win_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (this.win.Left == 0)
            {
                this.win.Left = -this.win.Width + 13;
            }
            if(this.win.Top == 0)
            {
                this.win.Top = -this.win.Height + 5;
            }
        }

        private void Win_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (this.win.Left < 0)
            {
                this.win.Left = 0;
            }if(this.win.Top < 0)
            {
                this.win.Top = 0;
            }
        }

        private void Win_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            double left = this.win.Left;
            double right = this.win.Left + this.win.Width;
            double top = this.win.Top;
            if (left < 0)
            {
                this.win.Left = -this.win.Width + 13;
            }
            if(top < 0)
            {
                this.win.Top = -this.win.Top + 5;
            }
        }
    }

}
