using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecladoVirtual.Modelos
{
    internal static class Estatica
    {
        public static List<Pessoa> listaPessoas = new List<Pessoa>();
        public static Controle controle;
        public static double mediaGeral;
        public static int numeroDePessoas;
        public static int totaldeAcertos;
    }
}
