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
    public class Controle 
    {
        public string mensagem;
        public int pessoa;
        public double media;
        Pessoa usuario;
        bool p1;
        bool p2;
        bool p3;
        bool p4;
        bool p5;

        public Controle(String nome, int idade)
        {
            Pessoa usuario = new Pessoa(nome, idade);
            this.usuario = usuario;
        }
        
        public void executar()
        {
            usuario.setRespostas(p1, p2, p3, p4, p5);
            Respostas respostas = new Respostas(usuario);
            VerificarAcertos verificarAcertos = new VerificarAcertos(respostas.acertos,respostas.erros);
            pessoa = respostas.numeroVisitante;
            media = pessoa / verificarAcertos._acertos.Length * 100;
            mensagem = verificarAcertos.ToString();
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
