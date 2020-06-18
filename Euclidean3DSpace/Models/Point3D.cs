using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidean3DSpace.Models
{
    struct Point3D
    {
        private decimal x;
        private decimal y;
        private decimal z;

        public decimal X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public decimal Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public decimal Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public Point3D(decimal x, decimal y, decimal z) :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            string result = string.Empty;

            if (X != 0)
            {
                result += X.ToString() + Environment.NewLine;
            }
            if (Y != 0)
            {
                result += Y.ToString() + Environment.NewLine;
            }
            if (Z != 0)
            {
                result += Z.ToString() + Environment.NewLine;
            }

            return result;
        }
    }
}
