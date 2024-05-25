using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using TecladoVirtual.Telas;

namespace TecladoVirtual.Modelos
{
    public class Controle : Pessoa
    {
        //Variaveis para atribuicao dos valores das perguntas
        bool p1;
        bool p2;
        bool p3;
        bool p4;
        bool p5;
        //Variaveis para atribuicao dos valores das sastifacoes
        bool s1;
        bool s2;
        bool s3;
        bool s4;
        bool s5;

        public Controle(String nome, int idade) : base(nome,idade)
        { 
        }

        public void executar()
        {
            this.setRespostas(p1, p2, p3, p4, p5);
            this.setSatisfacao(s1, s2, s3, s4, s5);
            Respostas respostas = new Respostas(this);
            VerificarAcertos verificarAcertos = new VerificarAcertos(respostas.acertos,respostas.erros);
            this.setMedia = verificarAcertos.ToString();
            Estatica.listaPessoas.Add(this);

        }

        //----------------------------------//----------------------------
        //------------------- Metodos para setar valores as perguntas--------------
        public void ReceberP1(bool p1)
        {
            this.p1 = p1;
        }

        public void ReceberP2(bool p2)
        {
            this.p2 = p2;
        }
        public void ReceberP3(bool p3)
        {
            this.p3 = p3;
        }
        public void ReceberP4(bool p4)
        {
            this.p4 = p4;
        }
        public void ReceberP5(bool p5)
        {
            this.p5 = p5;
        }
        //----------------------------------//----------------------------
        //------------------- Metodos para setar valores as sastifacore--------------
        public void Recebers1(bool s1)
        {
            this.s1 = s1;
        }

        public void Recebers2(bool s2)
        {
            this.s2 = s2;
        }
        public void Recebers3(bool s3)
        {
            this.s3 = s3;
        }
        public void Recebers4(bool s4)
        {
            this.s4 = s4;
        }
        public void Recebers5(bool s5)
        {
            this.s5 = s5;
        }
    }
}
