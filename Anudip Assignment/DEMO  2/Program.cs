using System; 
class  one { }
class two  { }  

namespace DEMO_2
{
    public class Program
    {
       public  static void test(object obj)
        {
            one x;
            two y;
            if (obj is one)
            {
                Console.WriteLine("class one"); 
                x = (one)obj;
            }
            else if (obj is two)
            {
                Console.WriteLine("class two");
                y = (two)obj;   
            }
            else
            {
                Console.WriteLine("None of the classes!");
            }
        }
        public static void main()
        {
            one o1 = new one();
            two o2 = new two();
            test(o1);
            test(o2);
            test("str");
            Console.ReadKey();
        }
    }
}
