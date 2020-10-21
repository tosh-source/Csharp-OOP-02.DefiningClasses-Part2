﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    [AttributeUsage(AttributeTargets.Struct |
      AttributeTargets.Class | AttributeTargets.Interface,
      AllowMultiple = true)]


    public class AuthorAttribute : System.Attribute

    {

        public string Name { get; private set; }



        public AuthorAttribute(string name)

        {

            this.Name = name;

        }

    }
}
