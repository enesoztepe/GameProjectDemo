using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class GameManager : IGameService
    {

        public void GameBuying(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " adlı kullanıcı " + game.Name + " adlı oyunu " + game.Price + " TL ye almıştır.");
        }

        public void GameBuying(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " adlı kullanıcı " + game.Name + " adlı oyunu " + (game.Price*campaign.RateOfDiscount) + " TL ye almıştır.");
        }
    }
}
