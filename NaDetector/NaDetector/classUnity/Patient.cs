using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PetDetector.classUnity
{
    class Patient
    {
        public string name { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string hostipalNumber { get; set; }
        public string cateGory { get; set; }
        public string bedNumber { get; set; }
        public double jingshi { get; set; }
        public string picturePath { get; set; }
        public double[] receiveData { get; set; }
        public int[] sequence { get; set; }//样本标号
        public Point[] coordinate { get; set; }//标号坐标
        public string remark { get; set; }
        public DateTime dateTime { get; set; }
        public bool ifChecked { get; set; }
    }
}
