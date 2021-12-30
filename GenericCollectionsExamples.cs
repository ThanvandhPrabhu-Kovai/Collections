using System;
using System.Collections.Generic;

namespace Collections
{

    public static class GenericClassExamples
    {

        public static void listExample()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.Write($"\n\nPrime numbers list has elements {primeNumbers.Count} and they are ");
            string listStr = String.Join(", ", primeNumbers.ToArray());
            Console.Write($"\n\n{listStr}\n\nRemoving element at index 3...\n\n");
            primeNumbers.Remove(3);
            Console.Write($"Now Prime numbers list has elements {primeNumbers.Count}\n\n");

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            string citiesStr;
            Console.Write($"\n\nCities list has elements {cities.Count} and they are ");
            citiesStr = String.Join(", ", cities.ToArray());
            Console.Write($"\n\n{citiesStr}\n\nInserting element at index 0...\n\n");
            cities.Insert(0, "India");
            Console.Write($"Now after insertion of element at index 0, Cities list has elements {cities.Count}\n\n");
            citiesStr = String.Join(", ", cities.ToArray());
            Console.Write($"\n\n{citiesStr}\n\n");
        }


        public static void dicitionaryExample()
        {
            IDictionary<int, string> aplhabetsWithCustomIndex = new Dictionary<int, string>();
            aplhabetsWithCustomIndex.Add(1, "A");
            aplhabetsWithCustomIndex.Add(2, "B");
            aplhabetsWithCustomIndex.Add(3, "C");
            aplhabetsWithCustomIndex.Add(4, "D");
            aplhabetsWithCustomIndex.Add(5, "E");
            Console.Write($"\n\nNo of pairs in dictionary is {aplhabetsWithCustomIndex.Keys.Count}, and the elements are\n\n");
            foreach (KeyValuePair<int, string> kvp in aplhabetsWithCustomIndex)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.Write("\n\nRemoving pair with key 3...");
            aplhabetsWithCustomIndex.Remove(3);
            Console.Write($"\n\nNow the no of pairs in dictionary is {aplhabetsWithCustomIndex.Keys.Count} and the elements are \n\n");


            foreach (KeyValuePair<int, string> kvp in aplhabetsWithCustomIndex)
            {
                Console.WriteLine("Key: {0}, Value: {1}\n", kvp.Key, kvp.Value);
            }

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.Write("\n\nElements of Cities dictionary - \n\n");

            foreach (var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}\n", kvp.Key, kvp.Value);
            }

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                   //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            Console.Write("\n\nElements of Cities dictionary after editing- \n\n");

            if (cities.ContainsKey("India"))
            {
                cities["India"] = "Coimbatore, Chennai";
            }

            foreach (var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}\n", kvp.Key, kvp.Value);
            }
        }
    }
}