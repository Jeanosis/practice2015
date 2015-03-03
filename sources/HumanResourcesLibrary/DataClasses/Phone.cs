using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public class Phone : IDeepCopy<Phone>
    {
        public Phone CreateDeepCopy()
        {
            Phone p = new Phone();
            // copy fields here
            return p;
        }
    }
}
