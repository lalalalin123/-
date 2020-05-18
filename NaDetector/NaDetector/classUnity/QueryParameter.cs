using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaDetector.classUnity
{
    class QueryParameter
    {
        public string name { get; set; }
        public string hospitalNumber { get; set; }
        public bool byTime { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool sorted { get; set; }//排序规则
    }
}
