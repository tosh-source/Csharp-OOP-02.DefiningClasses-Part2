﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses.Models
{
    class GenericList<T> : IEnumerable<T>
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

        public void Insert(T elementToInsert, int startIndex)
        {
            if (startIndex < 0 || startIndex > this.Elements.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                var tempArrOfElements = new T[Elements.Length + 1]; //New Array of Elements need to be bigger than initial array of Elements with ONE.

                //1.Copy first part of array.
                for (int firstPartOfElements = 0; firstPartOfElements < startIndex; firstPartOfElements++)
                {
                    tempArrOfElements[firstPartOfElements] = Elements[firstPartOfElements];
                }

                //2.Copy the element to insert.
                tempArrOfElements[startIndex] = elementToInsert;

                //3.Copy second part of array.
                for (int secondPartOfElements = Elements.Length - 1; secondPartOfElements > startIndex; secondPartOfElements--)
                {
                    tempArrOfElements[secondPartOfElements + 1] = Elements[secondPartOfElements];
                }

                this.Elements = tempArrOfElements;
            }
        }

        public void Clearing()
        {
            for (int index = 0; index <= Elements.Length - 1; index++)
            {
                this.Elements[index] = default(T);  //Get default value for current T element (depend on current T instance: int, string, Point3D and so on).
            }
        }

        public void FindingElement(T element)
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)Elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)Elements).GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.Elements.Length - 1)
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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
