using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrollment_System
{
    internal class DatabaseConnectionString
    {
        static String fileName = "Database.accdb";
        static String MainPath = AppDomain.CurrentDomain.BaseDirectory;
        //public static String connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + MainPath + fileName;
        public static String connectionString;
        public DatabaseConnectionString()
        {
            String Connection = MainPath.Replace("\\bin\\Debug","");
            connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Connection + fileName;
        }
    }
}
