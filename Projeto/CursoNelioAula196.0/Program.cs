using System;
using System.IO;

namespace Curso_Nelio_Aula1960
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ivan.ostorari\Desktop\C# COMPLETO PROGRAMAÇÃO ORIENTADO A OBJETOS + PROJETOS NÉLIO ALVES\PROJETOS\Projetos\Projeto_Xadrez_Curso_Nelio_Aula196.0\temp\file1.txt";

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}