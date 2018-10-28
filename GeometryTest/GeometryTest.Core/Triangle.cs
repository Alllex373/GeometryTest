using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTest.Core
{
    class Triangle : ShapeBase
    {
        public override double Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Width
        {
            get;
            set;
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public override double GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}
