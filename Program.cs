using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    
    class Program
    {



        class complex
        {
            int a;
            int b;

            public
                complex (int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            void set(int a , int b)
            {
                this.a = a;
                this.b = b;
            }

            public static complex operator + (complex b,complex a)
            {
                return new complex (a.a+b.a,a.b+b.b);
            }


            public static complex operator -(complex b, complex a)
            {
                return new complex(a.a - b.a, a.b - b.b);
            }

            public static complex operator *(complex b, complex a)
            {
                return new complex(a.a * b.a - a.b*a.b, a.a * b.b + a.b*b.a);
            }


            public override string ToString()
            {
                return a+"+"+b + "i";
            }
            ~complex() { }
        }








        static void Teilor(double x)
        {
            int x2=0;
            int step = 0;
            double arg = 0;
 
            while (Math.Round(Math.Log((1 + x) / (1 - x)),6) != Math.Round(2*arg,6))
             {

                arg += (Math.Pow(x, 2 * step + 1) / (2 * step + 1));


                x2++;
                step ++;
            }
            Console.Write( Math.Round(arg,7) + "      ");
            Console.WriteLine(x2);
        }

        static bool endspace(int i,String str)
        {
            int j = i;
            while(j>0)
            {
                if (str[j] != ' ')
                {


                    return true;
                }
                j--;
            }
            return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("7");

            


            String stree = "andre vasia gert";

            int counter7 = 0;


            for (int i = 0; i < stree.Length; i++)
            {
                if((stree[i] == ' ' && stree[i-1] != ' ') || (endspace(i,stree) && i== stree.Length-1) ) 
                {
                    counter7++;
                }
            }

            Console.WriteLine(counter7);






            Console.WriteLine("6");

            Random rnd = new Random();

            int size = 5;
            int[,] mas1 = new int[size, size];
                
            for (int i=0; i < size; i++)
            {for(int j=0; j< size; j++)
                {
                    mas1[i, j] = rnd.Next(1,100);
                    Console.Write(mas1[i,j]+"     ");
                }
                Console.WriteLine();
            }

            int sum1= 0;
            bool men0 = false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (mas1[j, i] < 0 )
                    {
                        men0 = true;
                        break;
                    } 
                    else
                    {
                        sum1 += mas1[j,i];
                    }
                }
                if (!men0)
                {
                    Console.Write(sum1 + "    ");
                }
                else { Console.Write(" -   "); }
                men0 = false;
                sum1 = 0;
            }

            Console.WriteLine();


            int sumdig = 0;
            int buff = 999999999;
            for (int i = 0; i < size-1; i++)
            {
                for (int j = size-1; j >= 0; j--)
                {
                    if (j - i >= 0)
                    {
                        
                        sumdig += mas1[j, size - 1 - j + i];
                    }
                }
                if (sumdig < buff)
                {
                    buff = sumdig;
                }
                sumdig = 0;
            }



            Console.WriteLine();
            int buff2 = buff;
            buff = 999999999;
            sumdig = 0;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j >= 0; j--)
                {
                    if (j + i <= size-1)
                    {
                        
                        sumdig += mas1[j, size - 1 - j - i];
                    }
                }
                if (sumdig < buff)
                {
                    buff = sumdig;
                }
                sumdig = 0;
            }

            Console.WriteLine( "min sum "+((buff < buff2) ? buff : buff2));


            Console.WriteLine("------------");

            List<int> mas = new List<int>() { 1, 2, 3, 4, 6, 9, 1, -45, 34, 56, 2, 31, 2, 3 };

            int interrval1 = 1;
            int interrval2 = 9 ;
            int beforeremove = mas.Count;
            int max = mas[0];
            for (int i=0; i < mas.Count; i++)
            {
                if (mas[i] > max) { max = mas[i]; }
            }
            int sum = 0;
            for (int i=0; i<mas.Count; i++)
            {
                if (mas[i] > 0) { sum += mas[i]; }
                else { break; }
            }

            for (int i = 0; i<mas.Count; i++)
            {
                if (mas[i] <= interrval2 && mas[i] >= interrval1)
                {
                    mas.RemoveAt(i);
                }
            }
            

            for (int i=mas.Count;i<beforeremove;i++)
            {
                mas.Add(0);
            }

            for (int i=0; i<mas.Count; i++)
            {

                Console.Write(mas[i]+"   ");
            
            }


            Console.WriteLine("max  " + max);
            Console.WriteLine("Sum   " + sum);

            complex  arr = new complex (1,2);
            complex arr2 = new complex(3, 4);

            Console.WriteLine(arr2 + arr);
            Console.WriteLine(arr2 - arr);
            Console.WriteLine(arr2 * arr);


            double a = 0,z1=0,z2=0;
            String str;
            

            Console.WriteLine("Pervoe");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);




            z1 = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) /( Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2.0));
            z2 = 2 * Math.Sin(a);
             z1 = Math.Round(z1, 9);
                z2 = Math.Round(z2, 9);
            Console.WriteLine(z1);
            Console.WriteLine(z2);
            

    
            Console.WriteLine( ((z1 == z2)? "verno" : "neverno") );
            



            //teylor 

            double x = 0,shag,xk;
            String str1;
            

            Console.WriteLine( "Введите х,шаг и х конечное");
            
            str1 = Console.ReadLine();
            x = Convert.ToDouble(str1);
            str1 = Console.ReadLine();
            shag = Convert.ToDouble(str1);
            str1 = Console.ReadLine();
            xk = Convert.ToDouble(str1);

            Console.WriteLine(" аргумент   значение      колличество  ");
            for (double i=x; i<=xk; i = i + shag)
            {
                Console.Write(i+ "            ");
                Teilor(i);
                
                
            }

            //



            Console.ReadKey();

        }
    }
}
