using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace FrameFromScratch.DataSettings
{
    public static class Settings
    {
        private static IDictionary PageObjectProperties;

        public static string HostURL => GetSetting("HostURL", string.Empty);
        public static string UserName => GetSetting("UserName", string.Empty);

        public static string Password => GetSetting("Password", string.Empty);

        public static string ProductName => GetSetting("ProductName", string.Empty);


        public static void Use(TestContext context)
        {
            PageObjectProperties = context.Properties;
        }

        private static string GetSetting(string key, string defaultValue = null)
        {

            if (PageObjectProperties != null && PageObjectProperties.Contains(key))
            {
                return PageObjectProperties[key].ToString();
            }
            return defaultValue;
        }

    }
}
