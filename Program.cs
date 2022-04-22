using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_04
{
    class Program
    {
        static List<Aluno> alunosList = new List<Aluno>();
        static Aluno[] alunosArry = new Aluno[3];

        enum Menu { Adicionar_Arry = 1, Adicinar_list = 2, Sair = 3 }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
//-------------------------------------------------------------------------
            while (escolheuSair == false)// Menu
            {
                Console.WriteLine("======= Bem Vindo AO Somar Notas! ======\n");
                Console.WriteLine("1-Adicionar Alunos em um ARRY:\n" +
                                  "2-Adicionar Alunos em uma Lista:\n" +
                                  "3-Sair");
                int intOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intOp;

                switch (opcao)
                {
                    case Menu.Adicionar_Arry:
                        AdicinarArray();
                        break;
                    case Menu.Adicinar_list:
                        AdicionarList();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
//-----------------------------------------------------------------------
        static void AdicinarArray() // Função adicinar no array
        {
            Console.Clear();
            Console.WriteLine("======== Adicionar 3 Alunos em ARRY! ========");
            int i = 0, contAluno = 1;
            float totalNotas = 0;
            while (i < 3)
            {
                Console.WriteLine("Adicionar aluno: " + contAluno);
                Console.Write("Nome:.... ");
                string nome = Console.ReadLine();
                Console.Write("Idade:.... ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Nota:.... ");
                float nota = float.Parse(Console.ReadLine());
                alunosArry[i] = new Aluno(nome,idade,nota);
                Console.WriteLine("---------------------------------------------");
                totalNotas += alunosArry[i].nota;
                i++;
                contAluno++;
            }
            Console.WriteLine("Os 3 ALunos já foram Adicionados no Arry...");
            Console.WriteLine("A Soma das notas é: "+totalNotas);
            Console.ReadLine();
        }
//---------------------------------------------------------------------------------
        static void AdicionarList() //função adicionar na List
        {
            Console.Clear();
            Console.WriteLine("======== Adicionar 3 Alunos em LIST! ========");
            int i = 0, contAluno = 1;
            float totalNotas = 0;
            while (i < 3)
            {
                Console.WriteLine("Adicionar aluno: " + contAluno);
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Nota: ");
                float nota = float.Parse(Console.ReadLine());
                alunosList.Add(new Aluno(nome, idade, nota));
                Console.WriteLine("---------------------------------------------");
                totalNotas += alunosList[i].nota;
                i++;
                contAluno++;
            }
            Console.WriteLine("Os 3 ALunos já foram Adicionados na List...");
            Console.WriteLine("A Soma das notas é: "+ totalNotas);
            Console.ReadLine();
        }            
    }
}

