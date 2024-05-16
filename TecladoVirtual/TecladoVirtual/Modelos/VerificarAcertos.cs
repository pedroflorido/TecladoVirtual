using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecladoVirtual.Modelos
{
    internal class VerificarAcertos
    {
        public int[] _acertos;
        int[] _erros;
        double resutadoAcertos = 0;
        double resutadoErros = 0;
        public VerificarAcertos(int[] acertos, int[] erros) {
        
            this._acertos = acertos;
            this._erros = erros;
            CalcularAcertos();
        } 
       
        private  double CalcularAcertos()
        {
             this.resutadoAcertos = 0;
             this.resutadoErros = 0;

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

        private void AtribuicaodovaloresStatic()
        {
            Estatica.totaldeAcertos += Convert.ToInt32(resutadoAcertos); 
            Estatica.numeroDePessoas += Convert.ToInt32(resutadoAcertos + resutadoErros) / 5;
            Estatica.mediaGeral = Estatica.totaldeAcertos * 100 / Estatica.numeroDePessoas /5;
        }
        public override string ToString()
        {
            AtribuicaodovaloresStatic();
            return Convert.ToString(CalcularAcertos());
        }
    }
}
