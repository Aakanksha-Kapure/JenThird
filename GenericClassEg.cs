using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjThirdApp
{
    class Sample<T>
    {
        T Name;
        T City;
        internal Sample(T Name, T City)
        {
            this.Name = Name;
            this.City = City;
        }
        //Normal Method
        internal void Add(int x, int y)
        {
            Console.WriteLine("Addition is :{0}", (x + y));
        }
        //Generic Method
        //<T>
        internal void SWap<T>(T x, T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("X is {0} || Y is {1}", x, y);
        }
    }
    /*Generic Constraints
     * where T:struct ---- Value Type
     * where T:class-----reference type
     * where T: new-----default parameter constraint
     * where T:<interface name>
     */

    class student<T> where T : struct
    {
        int id;
        int marks;
    }

    class GenericClassEg
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("Anu", "Chennai");
            sample.SWap<int>(6, 8);
            sample.SWap<string>("Hello", "Welcome");

            //struct constraint
            //error beacuse student class will accept only struct value(value type)
            //student<string> student = new student<string>();

            student<int> student1 = new student<int>();
        }
    }
}
