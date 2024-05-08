using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecladoVirtual.Modelos
{
    internal class apresentacaoRelatorio
    {
        float mediaDeAcertos;
        int[,] acertos = new int[4,1];
        public apresentacaoRelatorio(int[,] acertos)
        {
            this.acertos = acertos;
        }

    }
}
