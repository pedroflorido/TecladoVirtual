using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TecladoVirtual.Telas;

namespace TecladoVirtual.Modelos
{
    internal class Controle : Pessoa
    {
        public Controle(String nome, int idade) : base (nome,idade)
        {
            executar();
        }

        private void executar()
        {
            Respostas respostas = new Respostas(this);
            VerificarAcertos verificarAcertos = new VerificarAcertos(respostas.acertos,respostas.erros);
            
        }

        
       

    }
}
