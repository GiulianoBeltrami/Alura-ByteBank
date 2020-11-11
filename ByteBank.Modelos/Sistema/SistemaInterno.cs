
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BibliotecaByteBank.Sistema
{
    class SistemaInterno
    {
        public bool logar(Autenticavel funcionario,string senha)
        {
            bool UsuarioAutenticado = funcionario.Autenticar(senha);
            if (UsuarioAutenticado)
            {
                Console.WriteLine("Senha correta.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }

        }

    }
}
