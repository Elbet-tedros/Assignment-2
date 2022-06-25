// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class calc
{
    
    static void Main(string[] args)
    {
        double a;
        double b;
        double ans;
        string ops;
        string choose;
        


        Console.WriteLine("\t\t\t\tCalculator!");
        Console.WriteLine("\t\t\t\t-----------\n");
        do
        {
            Console.WriteLine("enter the first number =");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Choose an operator:(+,-,*,/,%)=");
            ops = Console.ReadLine();
            Console.WriteLine("enter the second number =");
            b = Double.Parse(Console.ReadLine());
           
             if(ops !="+"&& ops != "-"&&  ops != "*" && ops != "/" && ops != "%" )
            {
                Console.WriteLine("This operation is not available\n");
               

            }
            else if (ops == "+")
            {

                ans = a + b;
                Console.Write("sum="+ans);
            }
            else if (ops == "-")
            {
                ans = a - b;
                Console.Write("difference="+ans);
            }
            else if (ops == "*")
            {
                ans = a * b;
                Console.Write("multiplication="+ans);
            }
            else if (ops == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("denominator can not be zero\n");
                }
                else
                {
                    ans = a / b;
                    Console.Write("devision="+ans);
                }
            }
            else if (ops == "%")
            {
                ans = a % b;
                Console.Write("module="+ans);
            }
           
            Console.WriteLine("\nDo you want to calculate again( yes or no) \n");
            choose = Console.ReadLine();
            
        } while (choose == "yes");
        Console.ReadKey();


    }

  
}