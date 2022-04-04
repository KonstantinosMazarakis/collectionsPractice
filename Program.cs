using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            foreach (int i in numArray){
            Console.WriteLine(i);
            }

            string[] stringArray = {"Tim","Martin","Nikki","Sara"};
            foreach (string i in stringArray){
            Console.WriteLine(i);
            }  

            bool[] boolArray = {true,false,true,false,true,false,true,false,true,false};
            foreach (bool i in boolArray){
            Console.WriteLine(i);
            }
    
            List<string> iceCream = new List<string>();
            iceCream.Add("chocolate");
            iceCream.Add("banana");
            iceCream.Add("vanilla");
            iceCream.Add("cherry");
            iceCream.Add("strawberry");
            foreach (string i in iceCream){
            Console.WriteLine(i);
            }  
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.Remove(iceCream[2]);
            Console.WriteLine(iceCream.Count);
            Console.WriteLine("-------------");

            Dictionary<string,string> profile = new Dictionary<string,string>();
            Random rand = new Random(); 
            foreach (string i in stringArray){
            int index = rand.Next(iceCream.Count);
            profile.Add(i, iceCream[index]);
            } 
            foreach (KeyValuePair<string,string> i in profile){
            Console.WriteLine(i.Key + " - " + i.Value);
            } 





        }
            
    }
}
