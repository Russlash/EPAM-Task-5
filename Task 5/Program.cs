using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "[(]{})";
            var checker = new BracketsChecker();

            foreach (var ch in s)
                checker.Put(ch);

            Console.WriteLine(checker.Balanced);

            var s1 = "()[()]{()()[]}";
            var checker1 = new BracketsChecker();

            foreach (var ch1 in s1)
                checker.Put(ch1);

            Console.WriteLine(checker1.Balanced);

            Console.ReadLine();
        }
    }
}
