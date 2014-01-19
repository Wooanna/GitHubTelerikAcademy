using System;


namespace EmployeeRecords
{
    class EmployeeRecords
    {


        /*A marketing firm wants to keep record of its employees.
         * Each record would have the following characteristics – first name, 
         * family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999).
         * Declare the variables needed to keep the information for a 
         * single employee using appropriate data types and descriptive names*/

        static void Main(string[] args)
        {
            Console.Write("First Name:");
            string FirstName = Console.ReadLine();
            Console.Write("Last Name:");
            string FamilyName = Console.ReadLine();
            Console.Write("Age:");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Gender (M or F): ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("ID:");
            string IdNumber = Console.ReadLine();
            Console.Write("Unique Number (27560000 to 27569999): ");
            string UniqueNumber = Console.ReadLine();
            Console.WriteLine(new string('*', 40)); 
            Console.WriteLine("Name: {0} {1}\nAge: {2}\nGender: {3}\nID: {4}\nUnique Number: {5}",
                FirstName, FamilyName, age, gender, IdNumber, UniqueNumber);
            Console.WriteLine(new string('*', 40));
            
            
        }
    }
}
