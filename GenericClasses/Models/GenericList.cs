using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses.Models
{
    class GenericList<T>
    {
        private T[] elements;
        private int currentPosition = 0;

        public T[] Elements
        {
            get { return this.elements; }

            private set { this.elements = value; }
        }

        public GenericList(int elementsCapacity)
        {
            this.Elements = new T[elementsCapacity];
        }

        public void Add(T elements)
        {
            this.Elements[currentPosition] = elements;
            currentPosition++;
        }

        public void Remove(int index)  //Remove element by given index.
        {
            this.Elements[index] = default(T);  //Get default value for current T element (depend on current T instance: int, string, Point3D and so on).
        }

        public T this[int index]
        {
            get
            {
                if (index > Elements.Length - 1)
                {
                    throw new IndexOutOfRangeException();
                }

                return Elements[index];
            }
            private set
            {
                this.Elements[index] = value;
            }
        }
    }
}
