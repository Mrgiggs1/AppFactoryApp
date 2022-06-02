using Microsoft.Data.SqlClient;
using AccessLayer;

namespace FactoryApp
{
    internal class Program
    {
        static void Main()
        {
            string conString = "Server=tcp:appfactory.database.windows.net,1433;Initial Catalog=AFCentral;" +
                "Persist Security Info=False;User ID=rudolphpuane;Password=Rudolph123;" +
                " MultipleActiveResultSets=False;Encrypt=True;" +
                "TrustServerCertificate=False;Connection Timeout=30;";
                var con = new SqlConnection(conString);
                con.Open();

            enterValues(con);

        }
        public static void enterValues(SqlConnection con)
        {
            string dep;
            Console.WriteLine("Enter FirstName");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter Surname");
            string lName = Console.ReadLine();

            string fullName = fName + " " + lName;

            Console.WriteLine("Enter your SA ID");
            string ID = Console.ReadLine();

            Console.WriteLine("Enter your Parking Spot No.");
            string parkNo = Console.ReadLine();

            Console.WriteLine("Do you celebrate Birthdays?");
            string isBirthday = Console.ReadLine();

            Console.WriteLine("Write down Name of the department");
            dep = Console.ReadLine();

            Console.WriteLine("Write down your Positon Name");
            string positionName = Console.ReadLine();

            
            dataAccess.InsertData(fName, lName, fullName, ID, parkNo, isBirthday, positionName, dep, con);

        }

    }
}
