using System;
using System.IO;
using System.Collections.Generic;
using CursoNelioAula2111.Entities;

namespace CursoNelioAula2111
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ivan.ostorari\Desktop\Formacao_C_Sharp_2_Nelio_Alves\Principal\Projetos\CursoNelioAula211.1\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}