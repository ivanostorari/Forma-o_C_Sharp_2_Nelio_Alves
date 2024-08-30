using System;
using System.IO;

namespace Projeto_Xadrez_Curso_Nelio_Aula1970
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ivan.ostorari\Desktop\C# COMPLETO PROGRAMAÇÃO ORIENTADO A OBJETOS + PROJETOS NÉLIO ALVES\PROJETOS\Projetos\Projeto_Xadrez_Curso_Nelio_Aula197.0\temp\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
