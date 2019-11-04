using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.StockAccountManagement
{
    public class StockReportUtility
    {
        string path = @"C:\Users\admin\source\Bridge\ObjectOrientedPrograms\ObjectOrientedPrograms\StockAccountManagement\StockDetails.json";

        public void AddStock()
        {
            Console.WriteLine("Enter stock name");
            string stockName = Console.ReadLine();
            Console.WriteLine("Enter number of shares");
            int numberOfShares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter share price");
            int sharePrice = Convert.ToInt32(Console.ReadLine());
            var newStock = "{'stockName': '" + stockName + "' ,'numberOfShares':" + numberOfShares + ",'sharePrice':" + sharePrice + "}";
            var json = File.ReadAllText(path);
            var jsonObj = JObject.Parse(json);
            var stockArrary = jsonObj.GetValue("Stocks") as JArray;
            var newMember = JObject.Parse(newStock);
            stockArrary.Add(newMember);
            jsonObj["Stocks"] = stockArrary;
            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, newJsonResult);
            this.Dispaly();
        }

        public void StockValue()
        {
            Console.WriteLine("Enter Stock Name");
            string companyName = Console.ReadLine();
            var json = File.ReadAllText(path);
            var jObject = JObject.Parse(json);
            bool found = false;
            foreach(var details in jObject["Stocks"])
            {
                if(companyName == details["stockName"] +"")
                {
                    found = true;
                    Console.WriteLine("Stock Value is " + Convert.ToInt32(details["numberOfShares"]) * Convert.ToInt32(details["sharePrice"]));
                }
            }

            if (!found)
            {
                Console.WriteLine("Stock not found");
            }
        }
        
        public void Dispaly()
        {
            var json = File.ReadAllText(path);
            var jObject = JObject.Parse(json);
            Console.WriteLine("Stock Name   Number Of Shares   Share Price");
             foreach(var details in jObject["Stocks"])
            {
                Console.WriteLine(details["stockName"] + "\t" + details["numberOfShares"] + "\t\t  " + details["sharePrice"]);
            }            
        }
    }
}
