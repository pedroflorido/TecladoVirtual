using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecladoVirtual.Telas;

namespace TecladoVirtual.Modelos
{
    internal class MediaDasPerguntas
    {
 
 
        public MediaDasPerguntas()
        {
            CalcularMediaDecadaPergunta();
        }

        private void CalcularMediaDecadaPergunta()
        {
            
            
                for(int cont = 0;cont < Estatica.Somaacertos.Length;cont++)
                {
                    try
                    {
                    if (Estatica.Somaacertos[cont] != 0)
                    {
                        Estatica.mediaDasPerguntas[cont] = Estatica.Somaacertos[cont] * 100;
                        Estatica.mediaDasPerguntas[cont] /= Estatica.numeroDePessoas;
                    }
                    else
                    {
                        Estatica.mediaDasPerguntas[cont] += Estatica.Somaacertos[cont] * 100;
                       
                    }
                }
                catch(Exception ex) { };
                }
            
            mensagemDeMediaDasPerguntas();
        }

        public void mensagemDeMediaDasPerguntas()
        {
            Estatica.MediaDasPerguntasMensagem = "Primera pergunta a media de acertos é: " + Estatica.mediaDasPerguntas[0].ToString("F2") + "%" + "\n"+
            "Primera pergunta a media de acertos é: " + Estatica.mediaDasPerguntas[1].ToString("F2") + "%"+ "\n"+
            "Primera pergunta a media de acertos é: " + Estatica.mediaDasPerguntas[2].ToString("F2") + "%" + "\n"+
            "Primera pergunta a media de acertos é: " + Estatica.mediaDasPerguntas[3].ToString("F2") + "%" + "\n"+
            "Primera pergunta a media de acertos é: " + Estatica.mediaDasPerguntas[4].ToString("F2") + "%" + "\n";
        }


    }
}