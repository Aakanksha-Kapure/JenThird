using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjThirdApp
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        internal Person(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
    }
    class GenericEg
    {
        static void ListEg()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Mango");
            fruits.Add("Orange");
            fruits.Insert(1, "Pineapple");
            fruits.RemoveAt(3);
            //fruits.Add(10);--Typesafe cannot add int as its declared datatype is string

            List<string> Vegetables = new List<string>();
            Vegetables.Add("Carrot");
            Vegetables.Add("BeetRoot");
            Vegetables.AddRange(fruits);// adding one list to another which has same data type
            foreach (var list in fruits)
            {
                Console.WriteLine("Fruits:{0}", list);
            }
            Console.WriteLine("Vegetables");
            foreach (var list in Vegetables)
            {
                Console.WriteLine("Vegetables:{0}", list);
            }
        }
            static void DictionaryEg()
            {
                Dictionary<int, string> dt = new Dictionary<int, string>();
                dt.Add(1, "Java");
                dt.Add(2, "Networks");
                dt.Add(3, "AI");
                foreach (KeyValuePair<int, string> kp in dt)
                {
                    Console.WriteLine(kp.Key + " " + kp.Value);
                }
            }
            static void StackEg()
            {
                //push,pop,peek,contains,clear -- methods
                Stack<int> st = new Stack<int>();
                st.Push(40);
                st.Push(30);
                st.Push(10);
                st.Push(50);
                foreach (var stack in st)
                {
                    Console.WriteLine(stack);
                }
                st.Pop();
                Console.WriteLine("After 1 pop");
                foreach (var stack in st)
                {
                    Console.WriteLine(stack);
                }
                Console.WriteLine("Peek:{0}", st.Peek());
            }
        //static void SortedListEg()
        //{
        //    SortedList<string, string> SL = new SortedList<string, string>();
        //    SL.Add("A", "Angular");
        //    SL.Add("J", "JavaScript");
        //    SL.Add("O", "Operating System");
        //}
        static void Main()
        {
            ListEg();
            Console.WriteLine("Person details");
            Console.WriteLine("--------------------");
            List<Person> person = new List<Person>();
            person.Add(new Person(1, "SAI", "Pune"));
            person.Add(new Person(2, "RAM", "Mumbai"));
            person.Add(new Person(3, "Geetha", "Pune"));
            foreach (Person p in person)
            {
                Console.WriteLine("ID:{0} || name:{1} || City:{2}", p.id, p.name, p.city);
            }
            Console.WriteLine("-----------------------");
            DictionaryEg();
            Console.WriteLine("-----------------------");
            StackEg();
        }
    }
}
