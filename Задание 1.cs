using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8");
            Program[] programMass = new Program[Process.GetProcesses().Length];
            int a = 0;
            foreach (Process pro in Process.getProcesses())
            {
                programMass[a] = new Program(pro.Id, pro.ProcessName);
                a++;
            }
            for (int i = 0; i < programMass.Length; i++)
            {
                Console.WriteLine($"ID процесса {programMass[i].Id} {programMass[i].Name} ");
            }
            Console.Write("Ввидите ID процесса: ");
            int id = Convert.ToInt32(Console.ReadLine());
            int innum = Scan(programMass, id);
            if (innum = -1) Console.WriteLine("Процесс с таким ID не найден");
            Console.Write("Как вы хотели завершить процесс: 1 жестоко / 2 просто завершить:");
            int exit = Convert.ToInt32(Colsole.ReadLine());
            exit(programMass, innum, exit);
            Console.ReadKey();
            
        }
    }
}
