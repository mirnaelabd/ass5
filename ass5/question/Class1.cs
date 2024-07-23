using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass5.question1
{

    public class Point3D : IComparable<Point3D>, ICloneable
    {
        private int x;
        private int y;
        private int z;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }    
        public Point3D() : this(0, 0, 0)
        {
        }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

      
        public object Clone()
        {
            return new Point3D(this.x, this.y, this.z); // Perform a deep copy
        }

      
        public int CompareTo(Point3D other)
        {
            if (other == null)
                return 1;

            if (this.x.CompareTo(other.x) != 0)
                return this.x.CompareTo(other.x);
            else if (this.y.CompareTo(other.y) != 0)
                return this.y.CompareTo(other.y);
            else
                return this.z.CompareTo(other.z);
        }

     
        public static bool operator ==(Point3D p1, Point3D p2)
        {
     
            if (Object.ReferenceEquals(p1, null))
            {
                return Object.ReferenceEquals(p2, null);
            }

      
            return p1.Equals(p2);
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

        
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Point3D))
            {
                return false;
            }

            Point3D other = (Point3D)obj;
            return (this.x == other.x) && (this.y == other.y) && (this.z == other.z);
        }

        public override int GetHashCode()
        {
            return (x, y, z).GetHashCode();
        }

      
    }

}
