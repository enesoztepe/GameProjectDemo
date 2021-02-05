using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IGameService
    {
        public void GameBuying(Gamer gamer, Game game);
        public void GameBuying(Gamer gamer, Game game, Campaign campaign);

    }
}
