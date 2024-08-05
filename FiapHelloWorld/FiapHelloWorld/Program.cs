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
            // cria uma nova instancia da classe HelloModel
            Models.HelloModel model = new Models.HelloModel();
            // acessa a variável Mensagem da classe HelloModel
            Console.WriteLine(model.Mensagem);
            // trecho para manter a janela aberta
            Console.Read();
        }
    }
}
