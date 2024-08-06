using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapHelloWorld.Models
{
    public class Curso
    {
        public int Codigo;
        string NomeCurso;
        string NomeInstrutor;
        int cargaHorario;
        int minimoAlunos;
        int maximoAlunos;
        
        // construtores
        public Curso()
        {

        }

        public Curso(string nome, string instrutor)
        {
            this.NomeCurso = nome;
            this.NomeInstrutor = instrutor;
        }

        public Curso(string nome, int minimoAlunos, int maximoAlunos)
        {
            this.NomeCurso = nome;
            this.minimoAlunos = minimoAlunos;
            this.maximoAlunos = maximoAlunos;
        }

        public bool MatricularAluno(string nomeAluno)
        {
            return true;
        }

        public int ConsultarMaximoAlunos()
        {
            return this.maximoAlunos;
        }

        // o virtual indica que o método pode ser sobrescrito em uma classe derivada
        public virtual void ImprimirCurso()
        {
            Console.WriteLine("Olá");
        }
    }
}
