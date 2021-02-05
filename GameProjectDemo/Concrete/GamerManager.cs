using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Yeni kullanıcı sisteme eklenmiştir.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +"adlı kullanıcı sistemden silinmiştir.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "adlı kullanıcı güncellenmiştir.");
        }
    }
}
