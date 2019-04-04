using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
    class TetrisRectangle
    {
        private Rectangle _rectangle;
        private int _left;
        private int _top;

        public TetrisRectangle(int left, int top, int width, int height)
        {
            _rectangle = new Rectangle();
            _rectangle.Width = width;
            _rectangle.Height = height;
            _rectangle.Fill = new SolidColorBrush(Colors.Red);

            Canvas.SetTop(_rectangle, top);
            Canvas.SetLeft(_rectangle, left);

            _left = left;
            _top = top;
        }

        public int Top
        {
            get
            {
                return _top;
            }
            set
            {
                _top = value;
                Canvas.SetTop(_rectangle, _top);
            }
        }
        public int Left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
                Canvas.SetLeft(_rectangle, _left);
            }
        }
    }
}
