using System;
using System.Collections.Generic;
using SinglecastDelegate;
using MulticastDelegate;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            /* 
            1.What is a Delegate in C#? 
            Delegate is a type safe function pointer

            2.Why do we need delegates in C#?
            Delegate is used to declare an event and anonymous methods in C#.

            3.What are the benefits of delegates?
            Delegates allow methods to be passed as parameters and delegate instances attach or detach a method at run time making it more dynamic and flexible to use.
            
            4.What are types of delegates in C#?
            single, multicast and anonymous types of delegates.

           
           
            8.What are Anonymous Delegates in C#? and write a program for anonymous delegates


            */

            //6.What is a Singlecast delegate in C#? and write a program for singlecast delegate
            Console.WriteLine("Enter two numbers");//accepting two numbers
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Operations op1 = new Operations(Delegates.Addition);//creating new Singlecast delegate instance for addition 
            Console.WriteLine("Addition : {0}",op1(num1,num2));

            Operations op2 = new Operations(Delegates.Subtraction);//creating new Singlecast delegate instance for subtraction 
            Console.WriteLine("Subtraction : {0}", op2(num1, num2));

            //7.What is a Multicast delegate in C#? and write a program for muliticast delegates
            Console.WriteLine("\nMulticast delegate : ");//accepting two numbers
            
            Console.WriteLine("Enter Width of rectangle");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Length of rectangle");
            int length = Convert.ToInt32(Console.ReadLine());

            Rectangle rect = new Rectangle();
            RectangleDelegate rectDelegate = new RectangleDelegate(rect.GetArea);//creating new Singlecast delegate instance for subtraction 

            rectDelegate += rect.GetPerimeter;
            rectDelegate(width, length);

            Console.ReadLine();

        }
    }
}
