using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaByteBank.Exception;
using BibliotecaByteBank.funcionarios;
using BibliotecaByteBank.Sistema;

namespace BibliotecaByteBank
{
    public class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string profissao { get; set; }
        public override bool Equals(object obj)
        {
            Cliente outroCliente = obj as Cliente;
            if (outroCliente == null)
            {
                return false;
            }
            return this.cpf == outroCliente.cpf;
        }
    }
}
