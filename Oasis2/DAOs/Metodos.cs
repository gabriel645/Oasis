using Oasis2.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oasis2.DAOs
{
    public static class Metodos
    {
        public static bool ValidaInt(string valor)
        {
            int valorConvertido;
            return int.TryParse(valor, out valorConvertido);
        }
        
        public static bool ValidaDouble(string valor)
        {
            double valorConvertido;
            return double.TryParse(valor, out valorConvertido);
        }
        
        public static bool ValidaData(string data)
        {
            DateTime valorConvertido;
            return DateTime.TryParse(data, out valorConvertido);
        }
        
        public static bool Mensagem(string mensagem, TipoMensagemEnum tipoDaMensagem)
        {
            if (tipoDaMensagem == TipoMensagemEnum.alerta)
            {
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            
        else if (tipoDaMensagem == TipoMensagemEnum.erro)
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (tipoDaMensagem == TipoMensagemEnum.informacao)
            {
                MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if (MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
                    return true;
                else
                    return false;
            }
        }

    }
}
