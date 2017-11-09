using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace fileBower
{
    class winHide
    {
        private double Sx = SystemParameters.PrimaryScreenWidth;
        private double Sy = SystemParameters.PrimaryScreenHeight;
        private Window win;
        public winHide(Window win)
        {
            this.win = win;
        }
        public void start()
        {
            this.win.MouseLeftButtonUp += Win_MouseLeftButtonUp;
            this.win.MouseEnter += Win_MouseEnter;
            this.win.MouseLeave += Win_MouseLeave;
        }

        private void Win_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //throw new NotImplementedException();
            if(this.win.Left==0)
                this.win.Left = -this.win.Width + 2;
            if (this.win.Left == Sx - this.win.Width)
                this.win.Left = Sx - 2;
        }

        private void Win_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //throw new NotImplementedException();
            if(this.win.Left<0)
                this.win.Left = 0;
            if ((this.win.Left + this.win.Width) > Sx)
                this.win.Left = Sx - this.win.Width;
        }

        private void Win_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            double left = this.win.Left;
            double right = this.win.Left + this.win.Width;
            //throw new NotImplementedException();
            if (left < 0)
            {
                this.win.Left = -this.win.Width + 2;
            }
            if (right > Sx)
            {
                this.win.Left = Sx - 2;
            }
        }
    }

}
