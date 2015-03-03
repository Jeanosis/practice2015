﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public interface IDeepCopy<T>
    {
        T CreateDeepCopy();
    }
}
