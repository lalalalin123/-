using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace PetDetector
{
    class OperatorFile
    {
        [DllImport("kernel32")] //引入“shell32.dll”API文件
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);  
       // private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
        public OperatorFile()
        {

        }

        /// <summary>
        /// 从INI文件中读取指定节点的内容
        /// </summary>
        /// <param name="section">INI节点</param>
        /// <param name="key">节点下的项</param>
        /// <param name="def">没有找到内容时返回的默认值</param>
        /// <param name="filePath">要读取的INI文件</param>
        /// <returns>读取的节点内容</returns>
        public static string GetIniFileString(string section, string key, string def, string filePath)
        {
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString(section, key, def, temp, 1024, filePath);
            return temp.ToString();
        }
        public static bool SetIniFileString(string section, string key, string def, string filePath)
        {
            //StringBuilder temp = new StringBuilder(1024);
            try
            {
                WritePrivateProfileString(section, key, def, filePath);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool WriteIniData(string Section, string Key, string Value, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                long OpStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
                if (OpStation == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }

}
