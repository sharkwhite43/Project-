using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Deck52blade;
namespace project_Poke_deng
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Deck deck = new Deck();
            Pokedeng gamePlay = new Pokedeng("dealer", deck);
            Player mook = new Player("mook");
            Player Tan = new Player("Tan");
            gamePlay.AddPlayer(mook);
            gamePlay.AddPlayer(Tan);
            gamePlay.Play();
            //gamePlay.AllPlayerShowHands();



        }
    }
}
