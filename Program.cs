using Microsoft.Data.SqlClient;
using AccessLayer;
using MySql.Data.MySqlClient;



namespace FactoryApp
{
    internal class Program : dataAccess //inheritence
    {
        static void Main()
        {
            //this returns connection of database from sqlServer class library of class sqlServer
            var con = sqlServer.sqlserve();

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
                    Console.WriteLine("read by First Name,Surname, ID or All data");
                    string search = Console.ReadLine();
                    readData(search, con);
                    break;
                case 3:
                    //deleteFunction
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

            Console.WriteLine("Enter your Address");
            string address = Console.ReadLine();

            Console.WriteLine("Do you celebrate Birthdays?");
            string isBirthday = Console.ReadLine();

            Console.WriteLine("Write down Name of the department");
            dep = Console.ReadLine();

            Console.WriteLine("Write down your Positon Name");
            string positionName = Console.ReadLine();

            
            InsertData(fName, lName, fullName, ID, address, parkNo, isBirthday, positionName, dep, con);
        }

    }
}
