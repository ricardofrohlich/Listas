using System;
using System.Collections.Generic;
namespace Listas
{
    class Program
    {
        static List<Pessoa> pessoas;

        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(40, "Ricardo"));
            pessoas.Add(new Pessoa(25, "João"));
            pessoas.Add(new Pessoa(45, "Madalena"));
            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            }
            Console.WriteLine("Digite uma tecla para seguir");
            Console.ReadKey();            
            ListaNaoOrdenada();
            Console.WriteLine("Digite uma tecla para seguir");
            Console.ReadKey();
            ListaOrdenadaPorNome();
            Console.WriteLine("Digite uma tecla para seguir");
            Console.ReadKey();
            ListaOrdenadaPorIdade();
            Console.WriteLine("Digite uma tecla para seguir");
            Console.ReadKey();
            ListaInserirItemNaPosicao();
            Console.WriteLine("Digite uma tecla para seguir");
            Console.ReadKey();
            ListaNaoOrdenada();
            Console.WriteLine("Digite uma tecla para seguir");
            Console.ReadKey();
            ListaLocalizaPessoaMaisJovem();

        }
        static void ListaNaoOrdenada()
        {
            Console.WriteLine("Lista não ordenada");
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });
        }

        static void ListaOrdenadaPorNome()
        {
            Console.WriteLine("Lista Ordenada por Nome");
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Nome.CompareTo(p2.Nome);
            });
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });
        }

        static void ListaOrdenadaPorIdade()
        {
            Console.WriteLine("Lista Ordenada por Idade");
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Idade.CompareTo(p2.Idade);
            });
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });
        }


        static void ListaInserirItemNaPosicao()
        {
            Console.WriteLine("Inserindo uma pessoa na posição 1 e outra na posição 3");

            pessoas.Insert(1, new Pessoa() { Nome = "Bob Dylan", Idade = 78 });
            pessoas.Insert(3, new Pessoa() { Nome = "Jimmi Page", Idade = 81 });
        }

        static void ListaConverterParaArray()
        {
            Console.WriteLine("Convertendo a lista para um Array");
            Pessoa[] ListaArray = pessoas.ToArray();
            foreach (Pessoa p in ListaArray)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            }
        }

        static void ListaLocalizaPessoaMaisJovem()
        {
            List<Pessoa> jovem = pessoas.FindAll(delegate (Pessoa p) { return p.Idade < 45; });

            Console.WriteLine("Idade é menor que 25 : ");
            jovem.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            });
        }


    }
}


    
