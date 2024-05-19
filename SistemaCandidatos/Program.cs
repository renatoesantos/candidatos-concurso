using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCandidatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insira o número de candidatos: ");
                int n = int.Parse(Console.ReadLine());

                string[] candidatos = new string[n];
                float[] notas = new float[n];
                int aprovados = 0;
                int reprovados = 0;
                float somaNotas = 0;

                for (int i = 0; i < n; i++)
                {

                    Console.Write("Insira o nome do " + (i + 1) + "º candidato: ");
                    string nome = Console.ReadLine();

                    Console.Write("Insira a nota do " + (i + 1) + "º candidato: ");
                    float nota = float.Parse(Console.ReadLine());

                    candidatos[i] = nome;
                    notas[i] = nota;
                    somaNotas += nota;
                }
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("          Candidatos Concurso         ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Candidato           Nota        Status");

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{candidatos[i],-20} {notas[i],-10}");

                    if (notas[i] >= 8)
                    {
                        Console.WriteLine("Aprovado");
                        aprovados++;
                    }
                    else
                    {
                        Console.WriteLine("Reprovado");
                        reprovados++;
                    }

                }

                float mediaNotas = somaNotas / n;

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Aprovados: " + aprovados);
                Console.WriteLine("Reprovados: " + reprovados);
                Console.WriteLine("Nota média: " + mediaNotas);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro de formato: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }

            Console.WriteLine("Tecle para Continuar...");
            Console.ReadLine();
        }
    }    
}
