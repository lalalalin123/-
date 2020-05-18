using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace PetDetector
{
    /// <summary>  
    /// 对exe.Config文件中的appSettings段进行读写配置操作  
    /// 注意：调试时，写操作将写在vhost.exe.config文件中  
    /// </summary>  
    public class ConfigAppSettings
    {
        /// <summary> 
        /// 根据Key取Value值 
        /// </summary> 
        /// <param name="key"></param> 
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString().Trim();
        }

        /// <summary> 
        /// 根据Key修改Value 
        /// </summary> 
        /// <param name="key">要修改的Key</param> 
        /// <param name="value">要修改为的值</param> 
        public static void SetValue(string key, string value)
        {
            //ConfigurationManager.AppSettings.Set(key, value);
            //ConfigurationManager.RefreshSection("AppSettings");
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings"); // 重新加载新的配置文件
        }

        /// <summary> 
        /// 添加新的Key ，Value键值对 
        /// </summary> 
        /// <param name="key">Key</param> 
        /// <param name="value">Value</param> 
        public static void Add(string key, string value)
        {
            ConfigurationManager.AppSettings.Add(key, value);
            ConfigurationManager.RefreshSection("AppSettings");
        }

        /// <summary> 
        /// 根据Key删除项 
        /// </summary> 
        /// <param name="key">Key</param> 
        public static void Remove(string key)
        {
            ConfigurationManager.AppSettings.Remove(key);
            ConfigurationManager.RefreshSection("AppSettings");
        } 

    }  
}
