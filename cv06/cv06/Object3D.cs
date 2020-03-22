using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public abstract class Object3D : GrObject
    {
        public abstract double SumCapacity();
        public abstract double SumContent();
    }
}
