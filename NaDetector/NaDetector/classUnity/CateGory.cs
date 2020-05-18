using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetDetector.classUnity
{
    class CateGory
    {
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
