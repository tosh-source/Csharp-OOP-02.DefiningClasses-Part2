using System;  //needed for class Attribute

namespace Matrices
{
    [AttributeUsage(AttributeTargets.Struct |
      AttributeTargets.Class | AttributeTargets.Interface |
      AttributeTargets.Enum | AttributeTargets.Method)]

    public class VersionAttribute : Attribute
    {
        public int Major { get; private set; }

        public int Minor { get; set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }
}
