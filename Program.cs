using Microsoft.Data.SqlClient;
using AccessLayer;
using MySql.Data.MySqlClient;



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

            //procedure for user options to what they want to achieve with the system
            optionValues(con);

        }

        public static void optionValues(SqlConnection con)
        {
            Console.WriteLine("Press the following:\n1-Insert Data \n2-Read Data \n3-Delete Data \n4-Update Data");
            Console.WriteLine("==========================================================");
            var num = Console.ReadLine();

            switch (Convert.ToInt32(num))
            {
                case 1:
                    enterValues(con);
                    break;
                case 2:
                    break;
                default:

                    break;

            }

        }
        public static void enterValues(SqlConnection con)
        {
            string dep;
            Console.WriteLine("Provide Details");
            Console.WriteLine("==========================================================\n");

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
