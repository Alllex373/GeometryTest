using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTest.Core
{
    public abstract class ShapeBase
    {
        public abstract double Width {get;set;}
        public abstract double Height { get; set; }
        public abstract double GetPerimeter();

        public abstract double GetSquare();
    }
}
