using System;
using GameTOP.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jgo = new JogoFoda(new Jogador1(), new Jogador2());
            jgo.IniciarJogo();
        }
    }

}
