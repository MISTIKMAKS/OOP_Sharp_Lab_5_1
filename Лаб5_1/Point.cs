using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб5_1
{
    class Point
    {
        private double x;
        private double y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public double GetX()
        {
            return this.x;
        }

        public double GetY()
        {
            return this.y;
        }

        //Переміщення точки по осі +>
        public static Point operator -(Point p, double n)
        {
            p.x += n;
            return p;

        }

        //Переміщення по осі +^
        public static Point operator +(Point p, double n)
        {
            p.y += n;
            return p;
        }

        //Визначення відстані між точками ->
        public static double operator /(Point a, Point b)
        {
            double result = Math.Sqrt(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2));
            return result;
        }

        //Операції порівняння точок ==
        public static bool operator ==(Point a, Point b)
        {
            if (a.x == b.x && a.y == b.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Операції порівняння точок !=
        public static bool operator !=(Point a, Point b)
        {
            if (a.x == b.x && a.y == b.y)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static Point operator --(Point p)
        {
            p.x--;
            p.y--;
            return p;
        }

        public static Point operator ++(Point p)
        {
            p.x++;
            p.y++;
            return p;
        }

        public override string ToString()
        {
            return " x: " + this.x + "\n y: " + this.y;
        }
    }
}
