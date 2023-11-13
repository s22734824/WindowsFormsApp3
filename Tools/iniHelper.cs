using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tools.ini
{
    public class IniHelper
    {
        private string filePath;

        // 导入Windows API函数
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        // 构造函数
        public IniHelper(string path)
        {
            filePath = path;
        }

        public void setPath(string path)
        {
            filePath = path;
        }

        // 写入INI文件
        public void WriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, filePath);
        }

        // 读取INI文件
        public string ReadValue(string section, string key)
        {
            StringBuilder retVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", retVal, 255, filePath);
            return retVal.ToString();
        }

        public void DeleteKey(string section, string key)
        {
            WritePrivateProfileString(section, key, null, filePath);
        }
    }

}
