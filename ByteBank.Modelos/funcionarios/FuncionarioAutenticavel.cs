
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaByteBank.Sistema;


namespace BibliotecaByteBank.funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario,Autenticavel
    {
        private AutenticacaoHelper _AutenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }
        public bool Autenticar(string senha)
        {
            return _AutenticacaoHelper.CompararSenhas(this.Senha,senha);
        }
    }
}
