using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Yeni kullanıcı sisteme eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Doğrulama işlemi başarısız olmuştur.");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" adlı kullanıcı sistemden silinmiştir.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı kullanıcı güncellenmiştir.");
        }
    }
}
