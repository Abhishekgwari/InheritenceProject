using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceProject
{
    class Class2 : Class1
    {
       public Class2(int a) :base(a)
        {
            Console.WriteLine("Class 2 constructor  is callled");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");

        }
        static void Main()
        {   
            Class2 c = new Class2(50);    
         //   Object obj  = new object();
        //    Console.WriteLine(obj.GetType());
        //    Class1 p = new Class1();
        //    Console.WriteLine(p.GetType());
        //    Class2 c = new Class2();
        //    Console.WriteLine(c.GetType());

           
           // Class1 p;

//            Class2 c = new Class2();  // c is a instance of class 2
  //          p = c;
    //        p.Test1();
      //      p.Test2();  // p is a refrence of parent class by using child class instance
        //    c.Test1();
          //  c.Test2();
           //  c.Test3();
            
            Console.ReadLine();

        }
    }
}
