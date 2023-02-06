namespace CsvAndJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string jSONPath = @"C:\Users\Sartaj khan\source\repos\CsvAndJson\CsvAndJson\JSONContacts.json";
           
            PersonInput input = new PersonInput();
            //Getting details from user
            Console.WriteLine("\nEnter your First Name : ");
            input.First_Name = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.Address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.City = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.State = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.Email = Console.ReadLine();

            //Read and Write Operation in JSON Files
            JsonIOOperations.WriteRecordsInJSONFile(jSONPath, input);
            //JsonIOOperations.ReadRecordsInJSONFile(jSONPath);
            Console.ReadLine();
        }
        public static bool IsFileExists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                Console.WriteLine("File Not Found");
                return false;
            }
        }
    }
}

