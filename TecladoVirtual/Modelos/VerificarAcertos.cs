using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecladoVirtual.Modelos
{
    internal class VerificarAcertos
    {
        String acertos = "Parabens vc Acertou as perguntas : ";
        String erros = "E seus erros foram mas perguntas : ";
        int[] _acertos;
        int[] _erros;
        public VerificarAcertos(int[] acertos, int[] erros) {
        
            this._acertos = acertos;
            this._erros = erros;
            CalcularAcertos();
        }

        private double CalcularAcertos()
        {
            double resutadoAcertos = 0;
            double resutadoErros = 0;

            for (int cont = 0;  cont < _acertos.Length; cont++)
            {
                resutadoAcertos += _acertos[cont];
            }
            for(int cont = 0; cont < _erros.Length; cont++)
            {
                resutadoErros += _erros[cont];
            }

            return resutadoAcertos / 5 * 100;
        }

        public override string ToString()
        {
            return Convert.ToString(CalcularAcertos());
        }
    }
}
