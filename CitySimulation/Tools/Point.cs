using System;
using System.Collections.Generic;
using System.Text;

namespace CitySimulation.Tools
{
    public class Point
    {
        public int X;
        public int Y;

        public Point()
        {
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
        }

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X)* (p1.X - p2.X) + (p1.Y - p2.Y)*(p1.Y - p2.Y));
        }

        public static implicit operator Point((int, int) val)
        {
            return new Point(val.Item1, val.Item2);
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static Point operator /(Point p1, int val)
        {
            return new Point(p1.X/val, p1.Y/val);
        }

        public static Point operator *(Point p1, int val)
        {
            return new Point(p1.X * val, p1.Y * val);
        }

        public static Point operator *(int val, Point p1)
        {
            return p1 * val;
        }

        public static Point operator *(Point p1, double val)
        {
            return new Point((int)(p1.X * val), (int)(p1.Y * val));
        }

        public static Point operator *(double val, Point p1)
        {
            return p1 * val;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}
