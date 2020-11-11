
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaByteBank;
using BibliotecaByteBank.Exception;
using BibliotecaByteBank.funcionarios;
using BibliotecaByteBank.Sistema;


namespace BibliotecaByteBank
{
    class ParceiroComercial : Autenticavel
    {
        private AutenticacaoHelper _AutenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return _AutenticacaoHelper.CompararSenhas(this.Senha,senha);
        }

    }
}
