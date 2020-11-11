using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaByteBank.Sistema
{
    internal class AutenticacaoHelper //internal : ela funciona só no ByteBank.Modelos
    {
        public bool CompararSenhas(string SenhaVerdadeira , string SenhaTentativa)
        {
            return SenhaVerdadeira == SenhaTentativa;
        }
    }
}
