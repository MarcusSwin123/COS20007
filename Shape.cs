using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class Shape
    {
        private Color _color;
        private float _width, _height;
        private float _x, _y;
        public Shape()
        {
            _color = Color.Green;
            _width = _height = 100;
            _x = _y = 0;
        }
        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public Color color
        {
            get { return _color; }
            set { _color = value; }
        }
        public float Width 
        { 
            get { return _width; }
            set { _width = value; }
        }
        public float Height 
        { 
            get { return _height;} 
            set { _height = value; }
        }  
        public float x 
        { 
            get { return _x; } 
            set { _x = value; }
        }
        public float y 
        { 
            get { return _y; }
            set { _y = value; }
        }

        public bool IsAt(Point2D pt)
        {
            if (_x < pt.X && pt.X > _width && _x < pt.Y && pt.Y > _height);
            {
                return true;
            }
            return false;
        }
    }
}
