using System;
using System.IO;

namespace Curso_Nelio_Aula1980
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\ivan.ostorari\Desktop\C# COMPLETO PROGRAMAÇÃO ORIENTADO A OBJETOS + PROJETOS NÉLIO ALVES\PROJETOS\Projetos\Projeto_Xadrez_Curso_Nelio_Aula198.0\temp\file1.txt";
            string targetPath = @"C:\Users\ivan.ostorari\Desktop\C# COMPLETO PROGRAMAÇÃO ORIENTADO A OBJETOS + PROJETOS NÉLIO ALVES\PROJETOS\Projetos\Projeto_Xadrez_Curso_Nelio_Aula198.0\temp\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
