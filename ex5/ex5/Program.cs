using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.	Faça um algoritmo que leia um valor N e imprima a soma de todos os números pares
             * entre 1 (inclusive) e N (inclusive). Considere que o N será sempre maior que ZERO.*/

            Console.WriteLine("Exercicio 5");
            Console.WriteLine();

            Console.Write("Ultimo número do intervalo: "); //informa ao usuário o que ele deve digitar
            int ultimoNumero = Convert.ToInt32(Console.ReadLine()); //lê, converte e guarda o valor digitado

            int primeiroNumero = 1; //declara a variavel com valor 1
            int somaPares = 0; //declara a variavel com valor 0

            while (primeiroNumero <= ultimoNumero) //inicia o laço de repetiçao enquanto a variavel primeiroNumero for menor ou igual ao ultimoNumero
            {
                if (primeiroNumero % 2 == 0) //condiçao que detecta os numeros pares
                {
                    somaPares = somaPares + primeiroNumero; //adiciona o numero par a soma dos pares
                }
                primeiroNumero = primeiroNumero + 1; //adiciona +1 a variavel primeiroNumero
            }
            Console.WriteLine();
            Console.WriteLine("A soma dos números pares é: " + somaPares); //informa a soma dos numeros pares
            Console.ReadKey(); //encerramento do programa
        }
    }
}
