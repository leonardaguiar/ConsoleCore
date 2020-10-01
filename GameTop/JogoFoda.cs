using System;
using GameTOP.Interface;

namespace GameTop
{
    public class JogoFoda
    {
         private readonly ijogador _JogadorA;

         private readonly ijogador _JogadorB;



        public JogoFoda(ijogador jogadorA, ijogador jogadorB)
        {
            _JogadorA = jogadorA;
            _JogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            
            Console.Write(_JogadorA.Corre());
            Console.Write(_JogadorA.Passe());
            Console.Write(_JogadorA.Chuta());
            Console.Write("\n Próximo jogador \n");
            Console.Write(_JogadorB.Corre());
            Console.Write(_JogadorB.Passe());
            Console.Write(_JogadorB.Chuta());
            
        }
        
    }

  
}