using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonDemo gotInstance = SingletonDemo.getInstance();

            SingletonDemo singletonDemo = new SingletonDemo();
            MyDeligate myDeligate = new MyDeligate(singletonDemo.Sumation);
            int res = myDeligate(2, 3);
            Console.WriteLine(res.ToString());
        }
    }

    delegate int MyDeligate(int a, int b);
    public class SingletonDemo
    {
        private static volatile SingletonDemo instance = null;

        public SingletonDemo() { }

        public static SingletonDemo getInstance()
        {
            if (instance == null)
                instance = new SingletonDemo();


            return instance;
        }
        public int Sumation (int x, int y)
        {
            return x + y;
        }
    }
}
