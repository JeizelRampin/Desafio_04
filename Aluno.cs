using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_04
{
    public class Aluno
    {
        public string nome;
        public int idade;
        public float nota;

        public Aluno(string nome, int idade, float nota)
        {
            this.nome = nome;
            this.idade = idade;
            this.nota = nota;
        }
    }
}
