using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4program
{
    public class animal
    {
        public animal()
        {
            Console.WriteLine("I eat grass");
        }
        public animal(string name)
        {
            Console.WriteLine("I am "+ name);
        }
        public void whatIeat()
        {
            Console.WriteLine("I");
        }
        //destrctor
        ~animal()
        {
            Console.WriteLine("Hi");
        }
        //public void whatIeat(string food)
        //{
        //    Console.WriteLine("i eat food");
        //}
        //public void whatIeat(string food1, string food2)
        //{
        //    Console.WriteLine("i eat " + food1 + " and " + food2);
        //}

    }
    }
