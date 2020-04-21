﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class ComparerFactory : IComparerFactory
    {   
       public override ICustomComparer GetCustomComparer()
        {
            return new CustomComparer();
        }
    }
}
