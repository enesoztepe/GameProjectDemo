using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Update(Gamer gamer);
        public void Delete(Gamer gamer);
    }
}
