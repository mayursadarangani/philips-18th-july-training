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
            
            foreach(IPlotter p in plotters)
            {
                foreach(Shape s in _structure)
                {
                    s.Draw(p);
                }
            }
        }
    }

    public abstract class Shape
    {
        public abstract string Draw(IPlotter shapePlotter);
    }

    public class Rectangle : Shape
    {
        public override string Draw(IPlotter shapePlotter)
        {
            shapePlotter.Plot(this);
            return GetHeightAndWidth();
        }

        private string GetHeightAndWidth() { return "R.H.W";  }
    }

    public class Polygon : Shape
    {
        public override string Draw(IPlotter shapePlotter)
        {
            shapePlotter.Plot(this);
            return GetSides();
        }

        private string GetSides() { return "P.S"; }
    }

    public class Circle : Shape
    {
        public override string Draw(IPlotter shapePlotter)
        {
            shapePlotter.Plot(this);
            return GetRadius();
        }

        private string GetRadius() { return "C.R"; }
    }

    public interface IPlotter
    {
        void Plot(Rectangle rectangle);
        void Plot(Circle circle);
        void Plot(Polygon rectangle);   
    }

    public class LaserPrinter : IPlotter
    {
        public void Plot(Circle circle)
        {
            throw new NotImplementedException();
        }

        public void Plot(Polygon rectangle)
        {
            throw new NotImplementedException();
        }

        public void Plot(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }
    }

    public class InkJetPrinter : IPlotter
    {
        public void Plot(Circle circle)
        {
            throw new NotImplementedException();
        }

        public void Plot(Polygon rectangle)
        {
            throw new NotImplementedException();
        }

        public void Plot(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }
    }
}
