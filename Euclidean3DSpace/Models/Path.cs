using System.Collections;
using System.Collections.Generic;

namespace Euclidean3DSpace.Models
{
    public class Path
    {
        private ICollection<Point3D> points;

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public Path()
        {
            this.points = new List<Point3D>();
        }

        //Implement IEnumerable interface **
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
//** link-> https://support.microsoft.com/en-us/help/322022/how-to-make-a-visual-c-class-usable-in-a-foreach-statement
