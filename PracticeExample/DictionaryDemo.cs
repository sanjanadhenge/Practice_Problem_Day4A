using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExample
{
    internal class DictionaryDemo
    {
       //CURD Oprations on dictionary
       Dictionary<int,string> dict = new Dictionary<int,string>();
        public void DictionaryOprations()
        {
            //Adding elements to dictionary
            dict.Add(1, "Raj");
            dict.Add(2, "Rupali");
            dict.Add(3, "Anika");
            dict.Add(4, "Varun");
            dict.Add(5, "Ritu");
            //Retriving through dictionary
            Console.WriteLine("Elements of the Dictionary are : ");
            foreach(var item in  dict)
            {
                Console.WriteLine("key => "+item.Key +"\t"+ "Value => "+ item.Value);
            }
            //Deleting Particular element from dictionary
            dict.Remove(4);
            Console.WriteLine("After deleting element of the Dictionary : ");
            foreach (var item in dict)
            {
                Console.WriteLine("key => " + item.Key + "\t" + "Value => " + item.Value);
            }
        }


    }
}
