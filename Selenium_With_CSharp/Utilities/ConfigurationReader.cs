using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject2.Utilities
{
    public class ConfigurationReader
    {
        
        public static String getProperties(String name)
        {
            // correct file path is required
            String filepath =
                "/Users/maihemutimuhetaerjiang/RiderProjects/Selenium_With_C_Sharp/Selenium_With_CSharp/TestData.properties";
            
            return new ConfigurationReader(filepath).get(name );

        }
        
        
        
        
        
        private Dictionary<String, String> list;
        private String filename;
  
        public ConfigurationReader(String file)
        {
            reload(file);
        }
    
        public String get(String field)
        {
            return (list.ContainsKey(field))?(list[field]):(null);
        }
    
  
        public void reload(String filename)
        {
            this.filename = filename;
            list = new Dictionary<String, String>();

            if (System.IO.File.Exists(filename))
                loadFromFile(filename);
            else
                System.IO.File.Create(filename);
        }

        private void loadFromFile(String file)
        {
            foreach (String line in System.IO.File.ReadAllLines(file))
            {
                if ((!String.IsNullOrEmpty(line)) &&
                    (!line.StartsWith(";")) &&
                    (!line.StartsWith("#")) &&
                    (!line.StartsWith("'")) &&
                    (line.Contains('=')))
                {
                    int index = line.IndexOf('=');
                    String key = line.Substring(0, index).Trim();
                    String value = line.Substring(index + 1).Trim();

                    if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                        (value.StartsWith("'") && value.EndsWith("'")))
                    {
                        value = value.Substring(1, value.Length - 2);
                    }
                    list.Add(key, value);
               
                }
            }
        }
    }
}