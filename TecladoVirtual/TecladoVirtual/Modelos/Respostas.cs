using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TecladoVirtual.Modelos
{
    internal class Respostas
    {
        private Boolean[] perguntas = { true, false, true, false, false };
        public int[] acertos = {0,0,0,0,0};
        public int[] erros = {0,0,0,0,0};
        int cont = 0;
        Pessoa usuario;
        
        public Respostas(Pessoa usuario)
        {
            this.usuario = usuario;
            verificarResposta();
        }


        private void verificarResposta()
        {
            for (int cont = 0; cont < perguntas.Length; cont++)
            {
                if (perguntas[cont] == usuario.getRespostas()[cont])
                {
                    acertos[cont] += 1;
                    
                }
                else
                {
                    erros[cont] += 1;
                   
                }
            }
        
        }
       
    }
}

