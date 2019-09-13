using System.Windows;

namespace fileBower
{
    public class WinHide
    {
        private readonly double _screenWidth = SystemParameters.PrimaryScreenWidth;
        private readonly double _screenHeight = SystemParameters.PrimaryScreenHeight;
        private readonly Window _win;
        public WinHide(Window win)
        {
            this._win = win;
        }
        public void BindEvent()
        {
            this._win.MouseLeftButtonUp += Win_MouseLeftButtonUp;
            this._win.MouseEnter += Win_MouseEnter;
            this._win.MouseLeave += Win_MouseLeave;
        }

        private void Win_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (this._win.Left <= 0)
            {
                this._win.Left = -this._win.Width + 23;
            }
            if(this._win.Top <= 0)
            {
                this._win.Top = -this._win.Height + 15;
            }
        }

        private void Win_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (this._win.Left < 0)
            {
                this._win.Left = -10;
            }if(this._win.Top < 0)
            {
                this._win.Top = -10;
            }
        }

        private void Win_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            double left = this._win.Left;
            double right = this._win.Left + this._win.Width;
            double top = this._win.Top;
            if (left <= 0)
            {
                this._win.Left = -this._win.Width + 23;
            }
            if(top <= 0)
            {
                this._win.Top = -this._win.Top + 15;
            }
        }
    }

}
