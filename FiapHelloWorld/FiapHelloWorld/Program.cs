using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aula 2
            // int, long e double
            int valorInt = 100;
            long valorLong = valorInt;
            double valorDouble = valorLong;
            Console.WriteLine(valorInt);
            Console.WriteLine(valorLong);
            Console.WriteLine(valorDouble);

            // operadores 
            int soma = 10 + 3 + 4;
            int subtracao = soma - 10;
            int multiplicacao = subtracao * soma;
            double divisao = multiplicacao / soma;
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Multiplicação: " + multiplicacao);
            Console.WriteLine("Divisão: " + divisao);

            // if...else controle de fluxo
            int idade = 17;
            if (idade < 18)
            {
                Console.WriteLine("Você é menor de 18 anos.");
            }
            else
            {
                Console.WriteLine("Você é maior de 18 anos");
            }

            // estruturas de repetições - for
            for(int i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }

            // foreach
            string[] lista = { "Carlos", "Mario", "Antonio" };
            foreach(string nome in lista)
            {
                Console.WriteLine(nome);
            }

            // teste da classe Curso
            Models.Curso curso1 = new Models.Curso("Javascript", "Carlos");
            Models.Curso curso2 = new Models.Curso("Node.JS", 5, 40);

            // teste da classe derivada
            Models.CursoFerias cursoFerias1 = new Models.CursoFerias();

            // cria uma nova instancia da classe HelloModel
            Models.HelloModel model = new Models.HelloModel();
            // acessa a variável Mensagem da classe HelloModel
            Console.WriteLine(model.Mensagem);
            // trecho para manter a janela aberta
            Console.Read();
        }
    }
}
