using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Skinning.Theme
{
    public static class ResourceDictionaryExtensions
    {
        private static Guid CurrentThemeKey { get; } = Guid.NewGuid();
        public static void SetTheme(this ResourceDictionary resourceDictionary, ITheme theme)
        {
            if (resourceDictionary == null) throw new ArgumentNullException(nameof(resourceDictionary));
            SetDataTemplate(resourceDictionary, "EarthDataTemplate", theme.EarthDataTemplate);
            ITheme oldTheme = resourceDictionary.GetTheme();
            resourceDictionary[CurrentThemeKey] = theme;
        }

        public static ITheme GetTheme(this ResourceDictionary resourceDictionary)
        {
            if (resourceDictionary == null) throw new ArgumentNullException(nameof(resourceDictionary));
            if (resourceDictionary[CurrentThemeKey] is ITheme theme)
            {
                return theme;
            }

            return new Theme
            {
                EarthDataTemplate = GetDataTemplate("EarthDataTemplate")
            };

            DataTemplate GetDataTemplate(params string[] keys)
            {
                foreach (string key in keys)
                {
                    if (TryGetDataTemplate(key, out DataTemplate color))
                    {
                        return color;
                    }
                }
                throw new InvalidOperationException($"Could not locate required resource with key(s) '{string.Join(", ", keys)}'");
            }

            bool TryGetDataTemplate(string key, out DataTemplate template)
            {
                if (resourceDictionary[key] is DataTemplate temp)
                {
                    template = temp;
                    return true;
                }

                template = null;
                return false;
            }
        }

        internal static void SetDataTemplate(this ResourceDictionary sourceDictionary, string name, DataTemplate value)
        {
            if (sourceDictionary == null) throw new ArgumentNullException(nameof(sourceDictionary));
            if (name == null) throw new ArgumentNullException(nameof(name));

            sourceDictionary[name] = value;

            if (sourceDictionary[name] is DataTemplate template)
            {
                if (template == value) return;
            }

            var newTemplate = new DataTemplate(value);
            sourceDictionary[name] = newTemplate;
        }
    }
}
