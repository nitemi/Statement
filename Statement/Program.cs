using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void Main(string[] args)
    {
        //statem();
        biggest();
        /*Console.WriteLine("Enter a num between 1-9");
        int num = Convert.ToInt32(Console.ReadLine());

       
        if (num <= 3)
        {
            Console.WriteLine("Score is " + num * 10);
        }
        else if (num <= 7)
        {
            Console.WriteLine("Score is " + num * 100);
        }
        else if (num <= 9)
        {
            Console.WriteLine("Score is " + num * 1000);
        }
        else
        {
            Console.WriteLine("invalid input");
        }*/
    }

    public static void statem()
    {

        Console.WriteLine("Enter a num between 1-9");
        int num = Convert.ToInt32(Console.ReadLine());

        switch(num)
        {
          case 1:
            case 2:
            case 3:

                Console.WriteLine("Score is " + num * 10);
                break;
            case 4:
            case 5:
            case 6:

                Console.WriteLine("Score is " + num * 100);
                break;

            case 7:
            case 8:
            case 9:

                Console.WriteLine("Score is " + num * 1000);
                break;
            default:

                Console.WriteLine("invalid num");
                break;
        }

    }
    //Write a program that finds the biggest of three integers, using nested if statements.
    public static void biggest()
    {
        Console.WriteLine("Enter three numbers to find the biggest, press the enter key after each entry");
        int i = Convert.ToInt32(Console.ReadLine());
        int j = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        
        {
            if (i > k && i > j)
            {
                Console.WriteLine(" The biggest number is: ", i);
            }
            else
            {
                if (j > i && j > k)
                {
                    Console.WriteLine(" The biggest number is: ", j);
                }
                else
                {
                    if (k > i && k > j)
                    {
                        Console.WriteLine(" The biggest number is: " + k);
                    }
                    else
                    {
                        Console.WriteLine("The numbers are equal");
                    }
                }
            }
        }
    }
}