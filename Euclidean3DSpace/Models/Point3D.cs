using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidean3DSpace.Models
{
    public struct Point3D
    {
        private static readonly Point3D startCoordinate;
        private decimal x;
        private decimal y;
        private decimal z;

        public static Point3D StartCoordinate
        {
            get
            {
                return startCoordinate;
            }
        }
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

        static Point3D()
        {
            startCoordinate = new Point3D() { X = 0, Y = 0, Z = 0 };
        }
        public Point3D(decimal x, decimal y, decimal z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("X:{0} Y:{1} Z:{2}", X, Y, Z);

            return result;
        }
    }
}
