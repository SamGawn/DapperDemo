using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DapperPractice
{
    class Helper
    {
       public static string CnnValue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
