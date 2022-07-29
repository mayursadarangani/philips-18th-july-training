using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample
{
    class Program3
    {
        List<Shape> _structure = new List<Shape>();
       
        public void Plot(List<IPlotter> plotters)
        {
            //M*N cartesian product
            foreach (Shape s in _structure)
            {
                foreach (IPlotter p in plotters)
                {
                    p.PlotCircle(s as Circle);
                }
            }
        }
    }

    public abstract class Shape
    {
        public abstract string Structure();
    }

    public class Rectangle : Shape
    {
        public override string Structure()
        {
            return GetHeightAndWidth();
        }

        private string GetHeightAndWidth() { return "R.H.W";  }
    }

    public class Polygon : Shape
    {
        public override string Structure()
        {
            return GetSides();
        }

        private string GetSides() { return "P.S"; }
    }

    public class Circle : Shape
    {
        public override string Structure()
        {
            return GetRadius();
        }

        private string GetRadius() { return "C.R"; }
    }

    public interface IPlotter
    {
        void PlotRectangle(Rectangle rectangle);
        void PlotCircle(Circle circle);
        void PlotPolygon(Polygon rectangle);
    }

    public class LaserPrinter : IPlotter
    {
        public void PlotCircle(Circle circle)
        {
            throw new NotImplementedException();
        }

        public void PlotPolygon(Polygon rectangle)
        {
            throw new NotImplementedException();
        }

        public void PlotRectangle(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }
    }

    public class InkJetPrinter : IPlotter
    {
        public void PlotCircle(Circle circle)
        {
            throw new NotImplementedException();
        }

        public void PlotPolygon(Polygon rectangle)
        {
            throw new NotImplementedException();
        }

        public void PlotRectangle(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }
    }
}
