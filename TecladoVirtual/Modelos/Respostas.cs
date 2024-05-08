using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecladoVirtual.Modelos
{
    internal class Respostas
    {
        private Boolean[] perguntas = {true,false,false,true,true};
        public int[] acertos = new int[4];
        public int[] erros = new int[4];
        Pessoa usuario;
        
        public Respostas(Pessoa usuario)
        {
            this.usuario = usuario;
            verificarResposta();
        }
       

        private void verificarResposta()
        {
            int cont = 0;
           foreach(bool p in this.usuario.getRespostas())
            {
                foreach(bool q in perguntas)
                {
                    if(q == p)
                    {
                        this.acertos[cont] += 1 ;
                        cont++;
                    }
                    else
                    {
                        this.erros[cont] += 1 ;
                        cont++;
                    }
                }
            }
                
        }
    }
}

