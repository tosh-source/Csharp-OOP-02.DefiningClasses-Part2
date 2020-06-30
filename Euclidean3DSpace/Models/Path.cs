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
    }
}
