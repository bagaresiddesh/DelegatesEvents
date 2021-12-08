using System;

namespace SinglecastDelegate
{
    //5.How to define a delegates in C#? and write a syntax/definition for delegates
    public delegate int Operations(int num1, int num2);//defining a new delegate 

    public static class Delegates
    {
        public static int Addition(int n1,int n2)
        {
            return n1 + n2;
        }

        public static int Subtraction(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
