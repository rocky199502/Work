using System;

namespace Work
{
    class Program
    {
        static string[] VvodMass(int n)
        {
            string[] massive = new string[n];
            for(int i = 0; i< massive.Length;i++)
            {
                Console.WriteLine("Введите слово или символ: ");
                massive[i]=Console.ReadLine();
            }
            return massive;
        }
  
        static void OutMass(string[] massive)
        {
            Console.WriteLine("Полученный массив: ");
            for(int i = 0; i< massive.Length;i++)
            {
                Console.Write(massive[i]+" ");
            }
            Console.WriteLine(" ");
        }
  
        static string[] SortMass(string[] massive)
        {
            string[] Smassive = new string[massive.Length];
            int s = 0;
            for(int i = 0; i< massive.Length;i++)
            {
                if(massive[i].Length<=3)
                {
                    Smassive[s] = massive[i]; 
                    s++;
                }
            }
            Array.Resize(ref Smassive, s);
            return Smassive;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк которые вы хотите ввести: ");
            int N = int.Parse(Console.ReadLine());
            string[] massive = VvodMass(N);
            OutMass(massive);
            string[] Smassive = SortMass(massive);
            OutMass(Smassive);
            Console.WriteLine("Длинна нового массива: "+Smassive.Length);
        }
    }
}
