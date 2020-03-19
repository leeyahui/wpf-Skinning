using System;
using System.Windows;

namespace Skinning.Util
{
    static class ResourceHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public static void LoadResource(string fileName)
        {
            Application.Current.Resources.MergedDictionaries[0] = new ResourceDictionary()
            {
                Source = new Uri(fileName, UriKind.RelativeOrAbsolute)
            };
        }
    }
}
