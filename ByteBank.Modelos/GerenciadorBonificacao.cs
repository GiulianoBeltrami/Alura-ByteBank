using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using BibliotecaByteBank.Exception;
using BibliotecaByteBank.funcionarios;
using BibliotecaByteBank.Sistema;

namespace BibliotecaByteBank
{
    public class GerenciadorBonificacao
    {
        private double _BonificacaoTotal;
        public void Registrar(Funcionario funcionario )
        {
            _BonificacaoTotal += funcionario.GetBonificacao();
        }
        public double GetBonificacaoTotal()
        {
            return _BonificacaoTotal;
        }



    }
}
