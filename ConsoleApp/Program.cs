using System;
using SinglecastDelegate;
using MulticastDelegate;

public delegate string MyDel(string str);

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            /*        1.What is a Delegate in C#? 
                      Delegate is a type safe function pointer

                      2.Why do we need delegates in C#?
                      Delegate is used to declare an event and anonymous methods in C#.

                      3.What are the benefits of delegates?
                      Delegates allow methods to be passed as parameters and delegate instances attach or detach a method at run time making it more dynamic and flexible to use.

                      4.What are types of delegates in C#?
                      single, multicast and anonymous types of delegates. */

            //6.What is a Singlecast delegate in C#? and write a program for singlecast delegate
            //A Single-cast delegate can call only one method at a time
            Console.WriteLine("\nSingle delegate : ");
            Console.WriteLine("Enter two numbers");//accepting two numbers
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Operations op1 = new Operations(Delegates.Addition);//creating new Singlecast delegate instance for addition 
            Console.WriteLine("Addition : {0}", op1(num1, num2));

            Operations op2 = new Operations(Delegates.Subtraction);//creating new Singlecast delegate instance for subtraction 
            Console.WriteLine("Subtraction : {0}", op2(num1, num2));

            //7.What is a Multicast delegate in C#? and write a program for muliticast delegates
            // Multicast delegate can call multiple methods at the same time.
            Console.WriteLine("\nMulticast delegate : ");

            Console.WriteLine("Enter Width of rectangle");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Length of rectangle");
            int length = Convert.ToInt32(Console.ReadLine());

            Rectangle rect = new Rectangle();
            RectangleDelegate rectDelegate = new RectangleDelegate(rect.GetArea);//creating new Singlecast delegate instance for subtraction 

            rectDelegate += rect.GetPerimeter;
            rectDelegate(width, length);

            //8.What are Anonymous Delegates in C#? and write a program for anonymous delegates
            Console.WriteLine("\nAnonymous Delegates");
            int outsideScope = 99;
            State s = delegate (string state)
            {
                Console.WriteLine($"The state: {state} was entered!");
                Console.WriteLine($"The value from outer scope is: {outsideScope}");
            };
            s("up");

            //8.What is reflection? and write a program to use reflection.
            //Reflection provides objects (of type Type) that describe assemblies, modules, and types
            Console.WriteLine("\nReflection :");
            Type t = typeof(string);
            
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Full Name : {0}", t.FullName);
            Console.WriteLine("Namespace : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}", t.BaseType);

            //9.How to Use Events and Delegates in C#? and write a sample program using events
            //Event is an encapsulated delegate.
            //Console.WriteLine("\nEvents");
            //EventProgram obj1 = new EventProgram();

            //string result = obj1.MyEvent("Hello ");

            //Console.WriteLine(result);

            Console.ReadLine();
        }
        public class EventProgram
        {
            public event MyDel MyEvent;

            public EventProgram()
            {
                MyEvent += new MyDel(this.WelcomeUser);
            }

            public string WelcomeUser(string username)
            {
                return "Welcome " + username;
            }
        }       
    }
}
