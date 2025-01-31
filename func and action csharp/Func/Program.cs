﻿using System;

namespace Func
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Func<int,int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result); 

            // Func with an Anonymous Method
            Func<int> getRandomNumberWithAnonymous = delegate()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };

            // Func with Lambda Expression
            Func<int> getRandomNumberWithLambda = () => new Random().Next(1, 100);

            //Or 

            Func<int, int, int>  Sum2  = (x, y) => x + y;
        }
    }
}
