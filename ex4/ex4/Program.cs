using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.	Faça um algoritmo que exiba todos os números, a quantidade
             * de pares e a soma dos ímpares contidos no intervalo
             * digitado pelo usuário;*/

            Console.WriteLine("Exercicio 4");
            Console.WriteLine();

            Console.Write("Primeiro número do intervalo: "); //informa ao usuário o que ele deve digitar
            int primeiroNumero = Convert.ToInt32(Console.ReadLine()); //lê, converte e guarda o valor digitado

            Console.Write("ultimo número do intervalo: "); //informa ao usuário o que ele deve digitar
            int ultimoNumero = Convert.ToInt32(Console.ReadLine()); //lê, converte e guarda o valor digitado

            int qtdePares = 0; //declara a variavel com valor 0

            int somaImpares = 0; //declara a variavel com valor 0

            while (primeiroNumero <= ultimoNumero) //inicia o laço de repetiçao enquanto a variavel primeiroNumero for menor ou igual ao ultimoNumero
            {
                Console.WriteLine(primeiroNumero); //imprime na tela o valor da variavel primeiroNumero
                if (primeiroNumero % 2 == 0) //condiçao que detecta os numeros pares
                {
                    qtdePares = qtdePares + 1; //soma +1 a quantidade de pares
                }
                else //condiçao que detecta os numeros impares
                {
                    somaImpares = somaImpares + primeiroNumero; //adiciona o numero impar na soma dos impares
                }
                primeiroNumero = primeiroNumero + 1; //adiciona +1 a variavel primeiroNumero
            }
            Console.WriteLine("Quantidade de pares: " + qtdePares); //informa a quantidade de numeros pares
            Console.WriteLine("Soma dos impares: " + somaImpares); //informa a soma dos numeros impares
            Console.ReadKey(); //encerramento do programa
        }
    }
}