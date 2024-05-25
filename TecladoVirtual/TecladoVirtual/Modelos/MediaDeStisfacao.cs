using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecladoVirtual.Modelos
{
    internal class MediaDeStisfacao
    {
        
        public MediaDeStisfacao()
        {
            mediaDeStisfacao();
           
        }

        private void mediaDeStisfacao()
        {
            for(int cont = 0; cont < Estatica.controle.getSatifacao.Length; cont++)
            {
                if (Estatica.controle.getSatifacao[cont])
                {
                    Estatica.somasDosVotos[cont] += 1;
                }
            }
            CalculoMedia();
        }

        private void CalculoMedia()
        {
            for(int cont = 0; cont < Estatica.somasDosVotos.Length; cont++)
            {
                Estatica.mediaDasSastifacoes[cont] = Estatica.somasDosVotos[cont] * 100 / Estatica.numeroDePessoas;
               
            }
           atribuirResposta();
        }
        private void atribuirResposta()
        {
            Estatica.MediaDassatisfacaoMensagem = 
            "Opnião: Muito Ruim -   " + Estatica.mediaDasSastifacoes[0].ToString("F2") + "%" + "\n" +
            "Opnião: Ruim       -   " + Estatica.mediaDasSastifacoes[1].ToString("F2") + "%" + "\n" +
            "Opnião: Regular    -   " + Estatica.mediaDasSastifacoes[2].ToString("F2") + "%" + "\n" +
            "Opnião: Bom        -   " + Estatica.mediaDasSastifacoes[3].ToString("F2") + "%" + "\n" +
            "Opnião: Muito Bom  -   " + Estatica.mediaDasSastifacoes[4].ToString("F2") + "%" + "\n";
        }
    }
}
