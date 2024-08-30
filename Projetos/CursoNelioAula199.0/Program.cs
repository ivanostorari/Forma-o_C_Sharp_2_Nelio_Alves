using System;
using System.IO;


namespace Curso_Nelio_Aula1990
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ivan.ostorari\Desktop\C# COMPLETO PROGRAMAÇÃO ORIENTADO A OBJETOS + PROJETOS NÉLIO ALVES\PROJETOS\Projetos\Projeto_Xadrez_Curso_Nelio_Aula199.0\temp\myfolder";
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(@"C:\Users\ivan.ostorari\Desktop\C# COMPLETO PROGRAMAÇÃO ORIENTADO A OBJETOS + PROJETOS NÉLIO ALVES\PROJETOS\Projetos\Projeto_Xadrez_Curso_Nelio_Aula199.0\temp\myfolder\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

