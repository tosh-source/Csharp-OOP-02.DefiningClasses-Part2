﻿using System;
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
    }
}
