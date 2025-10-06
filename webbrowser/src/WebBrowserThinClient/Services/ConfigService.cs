using System;
using System.Collections.Generic;
using System.IO;

namespace WebBrowserThinClient.Services
{
    public static class ConfigService
    {
        private static readonly string ConfigFileName = "app.properties";
        private static Dictionary<string, string> _values;

        static ConfigService()
        {
            Load();
        }

        public static void Load()
        {
            _values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            try
            {
                var path = Path.Combine(AppContext.BaseDirectory, ConfigFileName);
                if (!File.Exists(path))
                {
                    return;
                }

                foreach (var line in File.ReadAllLines(path))
                {
                    var trimmed = line.Trim();
                    if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith("#"))
                        continue;

                    var idx = trimmed.IndexOf('=');
                    if (idx <= 0)
                        continue;

                    var key = trimmed.Substring(0, idx).Trim();
                    var value = trimmed.Substring(idx + 1).Trim();
                    _values[key] = value;
                }
            }
            catch
            {
                // swallow errors; defaults will be used
            }
        }

        public static string Get(string key, string defaultValue = null)
        {
            if (_values != null && _values.TryGetValue(key, out var v))
                return v;
            return defaultValue;
        }
    }
}
