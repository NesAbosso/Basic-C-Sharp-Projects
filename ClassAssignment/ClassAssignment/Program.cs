using System;

namespace ClassAssignment
{
    class Progam
    {
        //void method that divides an integer by 2 and output parameter
        static void Main(string[] args)
        {
            Divider div = new Divider();

            Console.WriteLine("Enter a number to divide: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result;

            div.Divide(num, out result);
            Console.WriteLine(result);
        }
    }
        }

//method overloading example
public class Methodoveloading
{
    public int add(int a, int b)  //two int type Parameters method  
    {
        return a + b;

    }
    public int add(int a, int b, int c)  //three int type Parameters with same method same as above  
    {
        return a + b + c;

    }
    public float add(float a, float b, float c, float d)  //four float type Parameters with same method same as above two method 
    {
        return a + b + c + d;
    }
}

//static class
public static class Utilities
{
    public static void DisplayMessage(string message)
    {
       
        Console.WriteLine(message);
      

    }
}










