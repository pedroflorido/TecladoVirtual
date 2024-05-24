using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecladoVirtual.Modelos
{
    public class Pessoa
    {
        private String _nome;
        private int _idade;
        private string media;
        private string mensagemDeAcertosEerros = "Parabens vc acertou as perguntas: ";
        private Boolean[] _respostas = { false, false, false, false, false };
        private Boolean[] _satifacao = { false, false, false, false, false };

        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public void setRespostas(Boolean p1, Boolean p2, Boolean p3, Boolean p4, Boolean p5)
        {
            _respostas[0] = p1;
            _respostas[1] = p2;
            _respostas[2] = p3;
            _respostas[3] = p4;
            _respostas[4] = p5;
        }
        public void setSatisfacao(Boolean s1, Boolean s2, Boolean s3, Boolean s4, Boolean s5)
        {
            _satifacao[0] = s1;
            _satifacao[1] = s2;
            _satifacao[2] = s3;
            _satifacao[3] = s4;
            _satifacao[4] = s5;
        }

        public Boolean[] getRespostas()
        {
            return _respostas;
        }
        public string getNome { get => _nome; }
        public int getIdade { get => _idade; }
        public string setMedia { set => media = value; get => media;}
        public string setMensagemDeAcertosEerros { get => mensagemDeAcertosEerros; set => mensagemDeAcertosEerros = value; }
        public bool[] setSatifacao { get => _satifacao;}
    }
}
