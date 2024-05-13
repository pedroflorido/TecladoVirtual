﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TecladoVirtual.Telas;

namespace TecladoVirtual.Modelos
{
    public class Controle : Pessoa
    {
        bool p1;
        bool p2;
        bool p3;
        bool p4;
        bool p5;

        public Controle(String nome, int idade) : base (nome,idade)
        {
            executar();
        }

        private void executar()
        {
            this.setRespostas(p1, p2, p3, p4, p5);
            Respostas respostas = new Respostas(this);
            VerificarAcertos verificarAcertos = new VerificarAcertos(respostas.acertos,respostas.erros);
           
        }

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
            
        

        
       

    }
}
