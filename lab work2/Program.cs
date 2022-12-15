using System;

namespace lab_work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Bir ədəd verilir. Əgər ədəd 5dən kiçikdirsə
            //ədəd bir vahid artır. Və əgər ədəd 5-ə
            //bərabərdirsə ekrana “Hello P232” çapa verilir.
            Console.WriteLine("eded daxil edin:");
            var number = Console.ReadLine();
            var num = Convert.ToInt32(number);
            if(num<5)
            {
                num++;
                if(num==5)
                {
                    Console.WriteLine("hello P232");
                }
                else
                {
                    Console.WriteLine("eded yanlisdir");
                }
            }
            else
            {
                Console.WriteLine("eded yanlisdir");
            }
            //Verilmiş N ədədinin özünün son
            //rəqəminə hasilini tapan proqram yazın(misalçün
            //132 ədədi verilibsə nəticədə 132*2 tapılmalıdır)
            int N = 132;

            int product = 1;
             int a = N % 10;
            product = N * a;
            Console.WriteLine(product);

            //Verilmiş 3 ədəddin son rəqəmlərinin kvadratları
            //cəmini tapan proqram yazın
            Console.WriteLine("task8");

            int num1 = 132;
            int num2 = 144;
            int num3 = 145;
            num1 = (num1 % 10)* (num1 % 10);

            num2 = (num2 % 10)*(num2 % 10);
            num3 = (num3 % 10)* (num3 % 10);
            var answer = num1 + num2 + num3;
            Console.WriteLine(answer);
            //Verilən 4 rəqəmli ədədin rəqəmlərininin tək olanların
            //cəmini və cüt olanlarının hasilinin
            //tapan proqram yazın.
            Console.WriteLine("ededi daxil edin:");
            var num4= Console.ReadLine();
            var Num4 = Convert.ToInt32(num4);

            var sum = 0;
            var Product = 1;

            int n;
            if(Num4>=1000&& Num4<=9999)
            {

            while ( Num4>0)
                {
                    n = Num4 % 10;
                    Num4 = (Num4 - n) / 10;
                    if(n%2==0)
                    {
                       Product*=n;
                    }
                    else
                    {
                        sum += n;
                    }
                   
                }
            Console.WriteLine(sum);
            Console.WriteLine(Product);
            }
          
           else
            {
                Console.WriteLine("eded 4 reqemli deyil");
            }
                   
                
         
            
          



        }
    }
}

