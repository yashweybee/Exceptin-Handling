using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptin_Handling
{
    class CollectionPractice
    {
        static void Main(string[] args)
        {
            //list
            var list1 = new List<string>();
            list1.Add("asdf");
            list1.Add("qwer");
            list1.Add("zxc");
            list1.Add("dfgh");

            List<int> intList = new List<int>();
            intList.Add(12);
            intList.Add(20);
            //intList.Remove(12);
            //intList.Reverse();

            var list2 = new List<int>() { 12, 45, 23, 456, 23 };




            //HashSet
            //HashSet<string> names = new HashSet<string>();
            var names = new HashSet<string>();
            names.Add("aaa");
            names.Add("bbb");
            names.Add("aaa");//not added

            //Sortedset
            var firstNames = new SortedSet<string>();
            firstNames.Add("opopop");
            firstNames.Add("xzcbf");
            firstNames.Add("opopop");
            firstNames.Add("asdf");
            //Console.WriteLine(firstNames.Count());


            //stack
            var myStack = new Stack<int>();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(40);
            myStack.Push(30);
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Peek());

            //Queue
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("aaaa");
            myQueue.Enqueue("hjhjh");
            myQueue.Enqueue("ioioio");

            myQueue.Dequeue();

            //LinkedList
            var myLl = new LinkedList<string>();
            myLl.AddLast("aaa");
            myLl.AddLast("bbb");
            myLl.AddFirst("ccc");

            //dictionary
            var myDec = new Dictionary<int, string>();
            myDec.Add(1, "aa");
            myDec.Add(2, "b");
            myDec.Add(3, "c");
            myDec.Add(4, "b");
            //Console.WriteLine(myDec.Keys.Count());



            //SortedDictionary
            var sortedDec = new SortedDictionary<int, string>();
            sortedDec.Add(1, "aa");
            sortedDec.Add(3, "bb");
            sortedDec.Add(4, "cc");
            sortedDec.Add(2, "cc");


            //sortedList
            var mySortedList = new SortedList<int, string>();
            mySortedList.Add(1, "aa");
            mySortedList.Add(2, "kk");
            mySortedList.Add(4, "aa");
            mySortedList.Add(3, "aa");

            foreach (KeyValuePair<int, string> kv in mySortedList)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }


            //foreach (var i in myLl)
            //{
            //    Console.WriteLine(i);
            //}



            Console.Read();
        }
    }
}
