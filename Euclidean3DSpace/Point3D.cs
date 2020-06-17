using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidean3DSpace
{
    struct Point3D
    {
        //static void Main(string[] args)
        //{
        //}

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
