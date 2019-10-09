using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellPhonesCatalog.Model;
using CellPhonesCatalog.Controller;
namespace NukisCell
{
    //1 set this project as startup project
    //2 add reference
    //3 add entity in the project -> tools-> NuGetPackageManager...
    // 4 Add the using's from model and controller
    class Program
    {
        static CellPhoneController cellPhones = new CellPhoneController();
        static void Main(string[] args)
        {
            //define a initial menu option
            var option = int.MinValue;
            //while != 0 stays at the loop
            while (option != 0)
            {
                Console.WriteLine("\nChoose a menu\n");
                Console.WriteLine("(1) - Register Phone\n");
                Console.WriteLine("(2) - Phone's List\n");
                Console.WriteLine("(3) - Update Phone\n");
                Console.WriteLine("(4) - Remove Phone\n");
                Console.WriteLine("(0) - Log off\n");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Loggin off...");
                        break;
                    case 1:
                        InsertCellPhone();
                        break;
                    case 2:
                        ReadPhonesList();
                        break;
                    case 3:
                        UpdatePhone();
                        break;
                    case 4:
                        RemovePhone();
                        break;
                    default://in case of an invalid option:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine("\nPress any key to go back at the initial menu");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        //CRUD
        //CREATE
        public static void InsertCellPhone()
        {
            Console.Clear();
            Console.WriteLine("----- Insert CellPhone -----");
            Console.Write("\n\nEnter the Phone Brand: ");
            var brandCell = Console.ReadLine();
            Console.Write("\n\nEnter the Phone Model: ");
            var modelCell = Console.ReadLine();
            Console.Write("\n\nEnter the Phone Price: ");
            var priceCell = double.Parse(Console.ReadLine());

            var result = cellPhones.AddCellPhone(new CellPhone()
            {
                Brand = brandCell,
                Model = modelCell,
                Price = priceCell
            });

            if (result)
                Console.WriteLine("\n\nSucessfully registered device!");
            else
                Console.WriteLine("\n\nError registering device");
        }
        //READ
        public static void ReadPhonesList()
        {
            cellPhones.GetCellPhones().ToList<CellPhone>().ForEach
               (x => Console.WriteLine($"Id: {x.Id}\nBrand: {x.Brand}\nModel: {x.Model}\nPrice: {x.Price}\n\n"));
        }
        //UPDATE
        public static void UpdatePhone()
        {
            Console.Clear();
            Console.WriteLine("----- UPDATE PHONE -----");
            ReadPhonesList();
            Console.WriteLine("\nEnter the ID to update the register data");
            var phoneToBeUpdated = int.Parse(Console.ReadLine());

            var updatedPhone = cellPhones.GetCellPhones().FirstOrDefault(x => x.Id == phoneToBeUpdated);

            if (updatedPhone == null)
                Console.WriteLine("ID Invalid");


            Console.Write("\n\nEnter the Phone Brand: ");
            updatedPhone.Brand = Console.ReadLine();
            Console.Write("\n\nEnter the Phone Model: ");
            updatedPhone.Model = Console.ReadLine();
            Console.Write("\n\nEnter the Phone Price: ");
            updatedPhone.Price = double.Parse(Console.ReadLine());

            var result = cellPhones.UpdateCellPhone(updatedPhone);

            if (result)
                Console.WriteLine("Phone Sucessfully updated!");
            else
                Console.WriteLine("Update Failed");
        }
        //DELETE

        public static void RemovePhone()
        {
            Console.Clear();
            Console.WriteLine("----- REMOVE PHONE -----");
            ReadPhonesList();
            Console.WriteLine("\nEnter the ID to remove");
            var phoneId = int.Parse(Console.ReadLine());

            var result = cellPhones.RemoveCellPhone(phoneId);

            if (result)
                Console.WriteLine("Phone sucessfully removed! ");
            else
                Console.WriteLine("Removing faild");
        }


    }
}
