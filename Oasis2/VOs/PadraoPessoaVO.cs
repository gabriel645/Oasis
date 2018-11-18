using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis2.VOs
{
    public class PadraoPessoaVO: PadraoVO
    {
        private string nome;
        private DateTime dataNasc;
        private int cpf;

        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public int Cpf { get => cpf; set => cpf = value; }
    }
}
