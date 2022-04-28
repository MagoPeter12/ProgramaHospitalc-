using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {

            Paciente[] lista = new Paciente[10];

            Console.WriteLine("Bem Vindo ao HDS");
            Console.WriteLine("Cadastro de Clientes");

            for (int i = 0; i<5; i++)
            {
                lista[i] = new Paciente();

                Console.WriteLine("Digite o nome do Paciente");
                lista[i].nome = Console.ReadLine();

                Console.WriteLine("Digite a idade");
                lista[i].idade = Console.ReadLine();

                Console.WriteLine("Digite o plano");
                lista[i].plano = Console.ReadLine();

                Console.WriteLine("Digite CPF");
                lista[i].cpf = Console.ReadLine();

                Console.WriteLine("Paciente preferencial? s/n");
                lista[i].cpf = Console.ReadLine();
            }
            if ()
            {

            }
                Console.ReadKey();


            }
        }
    }
