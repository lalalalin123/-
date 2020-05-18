using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using PetDetector.classUnity;
using System.Data;
using System.Runtime.InteropServices;

namespace PetDetector.toolUnity
{
    class Tool
    {
        public static void onlyDigit(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void onlyDigitLetter(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void onlyIP(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)46 || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        #region 序列化
        public static double[] byteToDouble(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            BinaryFormatter bf = new BinaryFormatter();
            return (double[])(bf.Deserialize(ms));
        }

        public static byte[] doubleToByte(double[] doubles)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, doubles);
            return ms.ToArray();
        }

        public static byte[] intToByte(int[] ints)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, ints);
            return ms.ToArray();
        }

        public static int [] buyeToInt(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            BinaryFormatter bf = new BinaryFormatter();
            return (int[])(bf.Deserialize(ms));
        }

        public static Point[] byteToPoint(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            BinaryFormatter bf = new BinaryFormatter();
            return (Point[])(bf.Deserialize(ms));
        }

        public static byte[] pointToByte(Point[] points)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, points);
            return ms.ToArray();
        }
        #endregion

        #region 文件输出

        /// <summary>
        /// 输出Word
        /// </summary>
        /// <param name="p"></param>
        public static void exportWord(Patient p)
        {
            string path= Application.StartupPath + @"\钠离子检测.docx";//用模板创建
            string hospitalName = OperatorFile.GetIniFileString("patientCheck", "name", "", Application.StartupPath + "\\setting.ini");
            Report report = new Report();
            report.CreateNewDocument(path);
            report.InsertValue("hospitalname", hospitalName);
            report.InsertValue("name", p.name);
            report.InsertValue("hospitalnumber", p.hostipalNumber.ToString());
            report.InsertValue("age", p.age.ToString());
            report.InsertValue("sex", p.sex);
            report.InsertValue("category", p.cateGory);
            report.InsertValue("bednumber", p.bedNumber.ToString());
            report.InsertValue("time", p.dateTime.ToString("yyyy-MM-dd hh:mm:ss"));
            report.InsertPicture("picture", p.picturePath,460,160);
            report.InsertValue("remark", p.remark);
            report.SaveDocument(Application.StartupPath + "\\word\\" + p.hostipalNumber.ToString() + " " + p.name + ".doc");
        }

        /// <summary>
        /// 输出PDF
        /// </summary>
        /// <param name="p"></param>
        public static void exportPdf(Patient p)
        {
            string path = Application.StartupPath + @"\钠离子检测.docx";//用模板创建
            string hospitalName = OperatorFile.GetIniFileString("patientCheck", "name", "", Application.StartupPath + "\\setting.ini");
            Report report = new Report();
            report.CreateNewDocument(path);
            report.InsertValue("hospitalname", hospitalName);
            report.InsertValue("name", p.name);
            report.InsertValue("hospitalnumber", p.hostipalNumber.ToString());
            report.InsertValue("age", p.age.ToString());
            report.InsertValue("sex", p.sex);
            report.InsertValue("category", p.cateGory);
            report.InsertValue("bednumber", p.bedNumber.ToString());
            report.InsertValue("time", p.dateTime.ToString("yyyy-MM-dd hh:mm:ss"));
            report.InsertPicture("picture", p.picturePath, 460, 160);
            report.InsertValue("remark", p.remark);
            report.SavePdf(Application.StartupPath + "\\pdf\\" + p.hostipalNumber.ToString() + " " + p.name + ".pdf");
        }
        #endregion

        #region 文件打印
        public static void printWord(Patient p)
        {
            string path = Application.StartupPath + @"\钠离子检测.docx";
            string hospitalName = OperatorFile.GetIniFileString("patientCheck", "name", "", Application.StartupPath + "\\setting.ini");
            Report report = new Report();
            report.CreateNewDocument(path);
            report.InsertValue("hospitalname", hospitalName);
            report.InsertValue("name", p.name);
            report.InsertValue("hospitalnumber", p.hostipalNumber.ToString());
            report.InsertValue("age", p.age.ToString());
            report.InsertValue("sex", p.sex);
            report.InsertValue("category", p.cateGory);
            report.InsertValue("bednumber", p.bedNumber.ToString());
            report.InsertValue("time", p.dateTime.ToString("yyyy-MM-dd hh:mm:ss"));
            report.InsertPicture("picture", p.picturePath, 460, 160);
            report.InsertValue("remark", p.remark);
            report.printWord();
        }

        public static void printWord(DataRow row)
        {
            string path = Application.StartupPath + @"\钠离子检测.docx";
            string hospitalName = OperatorFile.GetIniFileString("patientCheck", "name", "", Application.StartupPath + "\\setting.ini");
            Report report = new Report();
            report.CreateNewDocument(path);
            report.InsertValue("hospitalname", hospitalName);
            report.InsertValue("name", row["name"].ToString());
            report.InsertValue("hospitalnumber", row["hospitalnumber"].ToString());
            report.InsertValue("age", row["age"].ToString());
            report.InsertValue("sex", row["sex"].ToString());
            report.InsertValue("category", row["category"].ToString());
            report.InsertValue("bednumber", row["bednumber"].ToString());
            report.InsertValue("time", row["time"].ToString());
            report.InsertPicture("picture", row["picturepath"].ToString(), 460, 160);
            report.InsertValue("remark", row["remark"].ToString());
            report.printWord();
        }
        #endregion

        #region //更改行间距
        public const int WM_USER = 0x0400;
        public const int EM_GETPARAFORMAT = WM_USER + 61;
        public const int EM_SETPARAFORMAT = WM_USER + 71;
        public const long MAX_TAB_STOPS = 32;
        public const uint PFM_LINESPACING = 0x00000100;
        [StructLayout(LayoutKind.Sequential)]
        private struct PARAFORMAT2
        {
            public int cbSize;
            public uint dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;
            public int dySpaceBefore;
            public int dySpaceAfter;
            public int dyLineSpacing;
            public short sStyle;
            public byte bLineSpacingRule;
            public byte bOutlineLevel;
            public short wShadingWeight;
            public short wShadingStyle;
            public short wNumberingStart;
            public short wNumberingStyle;
            public short wNumberingTab;
            public short wBorderSpace;
            public short wBorderWidth;
            public short wBorders;
        }

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, ref PARAFORMAT2 lParam);

        /// <summary>
        /// 设置行距
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="dyLineSpacing">间距</param>
        public static void SetLineSpace(Control ctl, int dyLineSpacing)
        {
            PARAFORMAT2 fmt = new PARAFORMAT2();
            fmt.cbSize = Marshal.SizeOf(fmt);
            fmt.bLineSpacingRule = 4;// bLineSpacingRule;
            fmt.dyLineSpacing = dyLineSpacing;
            fmt.dwMask = PFM_LINESPACING;
            try
            {
                SendMessage(new HandleRef(ctl, ctl.Handle), EM_SETPARAFORMAT, 0, ref fmt);
            }
            catch
            {

            }
        }
        #endregion
    }
}
