using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapHelloWorld.Models
{
    public class CursoFerias: Curso
    {
        // o override indica que estamos sobreescrevendo o método da classe base.
        public override void ImprimirCurso()
        {
            Console.WriteLine("Tchau");
        }
    }
}
