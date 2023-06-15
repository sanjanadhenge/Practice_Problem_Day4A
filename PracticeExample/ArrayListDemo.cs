using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExample
{
    internal class ArrayListDemo
    {
        //CURD oprations on arraylist
        ArrayList list = new ArrayList();
        public void ArrayListOprations()
        {
            //Add elements to arraylist
            list.Add(5);
            list.Add(6.2f);
            list.Add("ABC");
            Console.WriteLine("Elements of the arraylist are ---");
            //Retriving Data of list
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            //Removing element from list
            list.Remove(6.2f);
            Console.WriteLine("After deleting element of the arraylist are ---");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
