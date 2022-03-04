using System;

namespace ShapeAnalyse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rectangle rectangle=new Rectangle(4, 5);
            Console.WriteLine("the area of rectangle is" + rectangle.getArea());
            Square square = new Square(4);
            Console.WriteLine("the area of square is"+square.getArea());
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine("the area of triangle is" + triangle.getArea());*/
            ShapeFactory shapeFactory = new ShapeFactory();
            Shape[] shapes = new Shape[10];
            shapes[1] = shapeFactory.getShape(4, 5);
            shapes[2]= shapeFactory.getShape(4, 5);
            shapes[3] = shapeFactory.getShape(4, 5);
            shapes[4]= shapeFactory.getShape(4);
            shapes[5] = shapeFactory.getShape(4);
            shapes[6] = shapeFactory.getShape(4);
            shapes[7] = shapeFactory.getShape(4, 5, 3);
            shapes[8] = shapeFactory.getShape(4, 5, 3);
            shapes[9] = shapeFactory.getShape(4, 5, 3);
            shapes[0] = shapeFactory.getShape(4, 5, 3);
            double areaSum = 0;
            for(int i = 0; i < 10; i++)
            {
                areaSum += shapes[i].getArea();
            }
            Console.WriteLine(areaSum);

        }
    }
    public interface Shape
    {
        double getArea();

        bool isShape();
    }
    public class Rectangle :Shape
    {
        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
            if (isShape())
            {
                Console.WriteLine("rectangle construsting");
            }
            else
            {
                Console.WriteLine("invaild width or lenghth");
            }
        }
        public bool isShape()
        {
            if (_width > 0 && _length > 0)
            {
                return true;
            }
            return false;
        }
        private double _length;
        private double _width;
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;

            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;

            }
        }
        public double getArea()
        {
            return _length * _width;
        }
    }
    public class Square : Shape
    {
        private double _width;
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public double getArea()
        {
            return _width * _width;
        }
        public bool isShape()
        {
            if (_width > 0)
            {
                return true;
            }
            return false;
        }
        public Square(double width)
        {
            _width = width;
            if (isShape())
            {
                Console.WriteLine("Square constructing");
            }
            else
            {
                Console.WriteLine("invaild width");
            }
        }

    }
    public class Triangle : Shape
    {
        private double _length1;
        public double Length1
        {
            get
            {
                return _length1;
            }
            set
            {
                _length1 = value;
            }

        }

        private double _length2;
        public double Length2
        {
            get
            {
                return _length2;
            }
            set
            {
                _length2 = value;
            }

        }

        private double _length3;
        public double Length3
        {
            get
            {
                return _length3;
            }
            set
            {
                _length3 = value;
            }

        }
        public double getArea()
        {
            double p = (_length1 + _length2 + _length3) / 2;
            return Math.Sqrt(p * (p - _length1) * (p - _length2 )* (p - _length3));
        }
        public bool isShape() {
            if (_length1 + _length2 > _length3 && Math.Abs(_length1 - _length2) < _length3)
            {
                return true;
            }
            return false;
        }

            public Triangle(double length1,double length2,double length3)
        {
            _length1 = length1;
            _length2 = length2;
            _length3 = length3;
            if (isShape())
            {
                Console.WriteLine("Triangle construting");
            }
            else
            {
                Console.WriteLine("invaild length");
            
              }
        }

      }
    public class ShapeFactory
    {
        public Shape getShape(double length,double width)
        {
            return new Rectangle(length,width);
        }
        public Shape getShape(double width){
            return new Square(width);
        }
        public Shape getShape(double length1,double length2,double length3)
        {
            return new Triangle(length1, length2, length3);
        }
    }
}
