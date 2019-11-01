using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.InventoryDataManagement
{
    public class InventoryUtility
    {
        public InventoryList List()
        {
            string path = @"C:\Users\admin\source\Bridge\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryDataManagement\InventoryDataManagement.json";
            //// read file into a string and deserialize JSON to a type
            InventoryList inventory = JsonConvert.DeserializeObject<InventoryList>(File.ReadAllText(path));
            //// deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                InventoryList list = (InventoryList)serializer.Deserialize(file, typeof(InventoryList));
                return list;
            }
        }

        public void Display()
        {
            var list = this.List();
                Console.WriteLine("\t\t Rice \n Name \t Total stock \t Price per kg");
                int totalRice = 0;
                foreach (var item in list.Rice)
                {
                    totalRice += item.Weight;
                    Console.WriteLine(item.Name + "\t\t" + item.Weight + "kg \t\t" + item.PricePerKg);
                }
                Console.Write("---------------------------------\nTotal   \t" + totalRice);

                Console.WriteLine("\n\n\t\t Pulses \n Name \t   Total stock \t Price per kg");
                int totalPulse = 0;
                foreach (var item in list.Pulses)
                {
                    totalPulse += item.Weight;
                    Console.WriteLine(item.Name + "\t" + item.Weight + "kg \t\t" + item.PricePerKg);
                }
                Console.Write("---------------------------------\nTotal   \t" + totalPulse);

                Console.WriteLine("\n\n\t\t Wheat \n Name \t   Total stock \t Price per kg");
                int totalWheat = 0;
                foreach (var item in list.Wheats)
                {
                    totalWheat += item.Weight;
                    Console.WriteLine(item.Name + "\t\t" + item.Weight + "kg \t\t" + item.PricePerKg);
                }
                Console.Write("---------------------------------\nTotal   \t" + totalWheat);
            
        }

        public void AddRice()
        {
            InventoryData data = new InventoryData();
            Console.WriteLine("Name of rice");
            data.Name = Console.ReadLine();
            Console.WriteLine("Weight of rice");
            data.Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price of rice per Kg");
            data.PricePerKg = Convert.ToInt32(Console.ReadLine());
            var list = this.List();
            foreach(var item in list.Rice)
            {
                Console.WriteLine(item.Name);
            }
            list.Rice.Add(data);
            foreach (var item in list.Rice)
            {
                Console.WriteLine(item.Name);
            }


        }

        

        public void AddWheat()
        {

        }

        public void AddPulse()
        {

        }

        public void DeleteRice()
        {

        }

        public void DeleteWheat()
        {

        }

        public void DeletePulse()
        {

        }

        public void EditRice()
        {

        }

        public void EditWheat()
        {

        }

        public void EditPulse()
        {

        }
        
    }
}
