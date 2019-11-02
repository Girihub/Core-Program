using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ObjectOrientedPrograms.InventoryDataManagement
{
    public class InventoryUtility
    {
        string path = @"C:\Users\admin\source\Bridge\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryDataManagement\InventoryDataManagement.json";
        public InventoryList List()
        {            
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

        public void AddItem(string item)
        {
            Console.WriteLine("Enter " + item + " name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter " + item + " weight");
            var weight = Console.ReadLine();
            Console.WriteLine("Price per 1 kg of " + item);
            var pricePerKg = Console.ReadLine();
            var newRice = "{'name': '" + name + "' ,'weight':" + weight + ",'pricePerKg':" + pricePerKg + "}";
            try
            {
                var json = File.ReadAllText(path);
                var jsonObj = JObject.Parse(json);
                var riceArrary = jsonObj.GetValue(item) as JArray;
                var newInventory = JObject.Parse(newRice);
                riceArrary.Add(newInventory);
                jsonObj[item] = riceArrary;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, newJsonResult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteItem(string item)
        {
            var json = File.ReadAllText(path);            
            Console.WriteLine("Enter the " + item + " type you want to delete");
            string itemType = Console.ReadLine();
            var jObject = JObject.Parse(json);
            JArray itemArrary = (JArray)jObject[item];
            bool found = false;
                foreach (var x in jObject[item])
                {
                    if (x["name"] + string.Empty == itemType)
                    {
                        var itemToDelete = itemArrary.FirstOrDefault(obj => obj["name"].Value<string>() == itemType);
                        itemArrary.Remove(itemToDelete);
                        jObject[item] = itemArrary;
                        string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(path, output);
                        found = true;
                        return;
                    }                                        
                }
            if (!found)
            {
                Console.WriteLine("File not found");
            }
        }

        public void EditItem(string item)
        {
            var json = File.ReadAllText(path);
            Console.WriteLine("Enter the " + item +" type you want to edit");
            string itemType = Console.ReadLine();
            var jObject = JObject.Parse(json);
            JArray itemArrary = (JArray)jObject[item];
            bool found = false;
            foreach (var updateItems in itemArrary.Where(obj => obj["name"].Value<string>() == itemType))
            {
                Console.WriteLine("Enter new name");
                updateItems["name"] = Console.ReadLine();
                Console.WriteLine("Enter new weight");
                updateItems["weight"] = Console.ReadLine();
                Console.WriteLine("Enter new price per kg");
                updateItems["pricePerKg"] = Console.ReadLine();
                found = true;
            }
            jObject[item] = itemArrary;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, output);            
            if (!found)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
