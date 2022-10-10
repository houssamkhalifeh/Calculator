using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
//using System.Web.Security;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bye World!");
            var a = 1;
            // BAD, Encrypt not specified
            string connectString =
                "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);
            var conn = new SqlConnection(builder.ConnectionString);            
            
        }
        static bool foo(bool a, bool b, bool c, bool d, bool e, bool f, bool g)
        {
            bool x = a || b || c || d || e || f || g; // OK
            bool y = a && b || !(b && c) || !(d && e) && !(f && g); // NOT OK
            bool z = (a && b || (b && c)) && ((d && e) || (f && g)); // NOT OK
            return x && y && z; // OK
        }




    }
}
