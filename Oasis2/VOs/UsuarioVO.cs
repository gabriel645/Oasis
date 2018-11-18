using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis2.VOs
{
    public class UsuarioVO: PadraoPessoaVO
    {
        private int telefone;
        private string email;

        public int Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        //foto!


    }
}
