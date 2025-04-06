
//WCP for division using division. if user enter zero it should display pls enter othern than zero.
/*namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        while(b==0)
        {
            Console.WriteLine("Pls Enter number othrethan zero");

            b = int.Parse(Console.ReadLine());      
        }
        int div = a / b;
        Console.WriteLine("Division result is:" + div);
        Console.ReadLine();
    }
}

//above code using forloop 
namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        for (; b == 0;)
        {
            Console.WriteLine("Pls Enter number othrethan zero");
            b = int.Parse(Console.ReadLine());
        }
        int div = a / b;
        Console.WriteLine("Division result is:" + div);
        Console.ReadLine();
    }
}


//WCP using while
//1 2 3 4 5
//10
//9
//8
//7
//6
namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 10;
        while (a <= 5)
        {
            Console.Write(a + " ");
            a++;
        }
        Console.WriteLine();
        while (b >= 6)
        {
            Console.WriteLine(b);
            b--;
        }
        Console.ReadLine();
    }
}


//WCP using do while. It will exixute 1 iteration even if the condition is false.
//1 2 3 4 5
//10
//9
//8
//7
//6

namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        int j = 10;
        do
        {
            Console.Write(i + " ");
            i++;
        }
        while (i <= 5);
        Console.WriteLine();
        do
        {
            Console.WriteLine(j + " ");
            j--;
        }
        while (j >= 6);
        Console.ReadLine();
    }
    
}


//1
//1 2
//1 2 3
//1 2 3 4
//1 2 3 4 5 using nested loop 
namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 1; i<=1; i++)
        {
            Console.WriteLine(i);
            for (int j = 1; j <= 2; j++)
            {
                Console.Write(j + "   ");
            }
            Console.WriteLine();
            for (int k = 1; k <= 3; k++)
            {
                Console.Write(k + "   ");
            }
            Console.WriteLine();
            for (int l = 1; l <= 4; l++)
            {
                Console.Write(l + "   ");
            }
            Console.WriteLine();
            for (int m = 1; m <= 5; m++)
            {
                Console.Write(m + "   ");
            }
        }
        
        Console.ReadLine();
    }

}


//1
//2 3
//4 5 6
//7 8 9 10 --using nested loop.
namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i<=1; i++)
        {
            Console.WriteLine(i);
            for (int j = 2; j <= 3; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            for (int k = 4; k <= 6; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            for (int l = 7; l <= 10; l++)
            {
                Console.Write(l + " ");
            }
            
        }
        

        Console.ReadLine();
    }

}


//1 2 3 4 5
//1 2 3 4
//1 2 3
//1 2
//1
namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for(int j= 1; j<=4; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
        for(int k=1; k<=3; k++)
        {
            Console.Write(k + " ");
        }
        Console.WriteLine();
        for(int l = 1; l<=2; l++)
        {
            Console.Write(l + " ");
        }
        Console.WriteLine();
        for (int m=1; m<=1; m++)
        {
            Console.WriteLine(m);
        }
        Console.ReadLine();
    }

}


// 5    4   3   2   1
// 4    3   2   1
// 3    2   1
// 2    1
// 1
namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 5; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int j = 4; j >= 1; j--)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
        for (int k = 3; k >= 1; k--)
        {
            Console.Write(k + " ");
        }
        Console.WriteLine();
        for (int l = 2; l >= 1; l--)
        {
            Console.Write(l + " ");
        }
        Console.WriteLine();
        for (int m = 1; m >= 1; m--)
        {
            Console.WriteLine(m);
        }
        Console.WriteLine();
        
        Console.ReadLine();
    }

}


// 5    5   5   5   5
// 4    4   4   4
// 3    3   3
// 2    2
// 1
namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        
        Console.ReadLine();
    }

}


//break condition:
namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            if (i==5)
            {
                break;
            }
            
        }

        Console.ReadLine();
    }

}


//Continue condition:

namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {

            if (i == 6)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }

}
*/

//1
//1 2
//1 2 3
//1 2 3 4
//1 2 3 4 5 using nested loop 
namespace Whileloop;

class Program
{
    static void Main(string[] args)
    {
        int printnum = 1;

        for (int i = 1; i <= 4; i++)
        {
            for(int j=1; j<=i; j++)
            Console.WriteLine(printnum + " ");
            printnum++;

        }
        Console.WriteLine();
        Console.ReadLine();
    }

}