using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis2.VOs
{
    public class LivrosVO: PadraoVO
    {
        private string localizacao;
        private string nome;
        private string autor;
        private string editora;
        private int ano;
        private int edicao;
        private string genero;
        private string tema;

        public string Localizacao { get => localizacao; set => localizacao = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        public int Ano { get => ano; set => ano = value; }
        public int Edicao { get => edicao; set => edicao = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Tema { get => tema; set => tema = value; }
    }
}
