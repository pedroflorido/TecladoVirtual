using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecladoVirtual.Modelos
{
    internal class MediaDeStisfacao
    {
        int[] somasDosVotos;
        public MediaDeStisfacao()
        {
            mediaDeStisfacao();
        }

        private void mediaDeStisfacao()
        {
            for(int cont = 0; cont < Estatica.controle.setSatifacao.Length; cont++)
            {
                if (Estatica.controle.setSatifacao[cont])
                {
                    somasDosVotos[cont] += 1;
                }
            }
            CalculoMedia();
        }

        private void CalculoMedia()
        {
            for(int cont = 0; cont < somasDosVotos.Length; cont++)
            {
                Estatica.mediaDasSastifacoes[cont] = somasDosVotos[cont] * 100 / Estatica.numeroDePessoas;
            }
        }
    }
}
