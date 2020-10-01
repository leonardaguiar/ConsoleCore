using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : ijogador
    {
         public readonly string _Nome;
        public Jogador2(string nome = "Maradona")
        {
            _Nome = nome;
        }
        
        public string Chuta() 
        {
            return $"{_Nome} está chutando \n";
        }

        public string Corre() 
        {
            return $"{_Nome} está correndo \n";
        }

         public string Passe() 
        {
            return $"{_Nome} está passando \n";
        }
    }
}