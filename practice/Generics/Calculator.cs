﻿using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public  class Calculator <T>
    {
        public static bool AreEqual (T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
