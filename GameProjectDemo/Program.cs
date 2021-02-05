using System;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Enes",
                LastName = "ÖZTEPE",
                DateOfBirth = new DateTime(2000, 1, 1),
                NationalityId = "12345678910"
            }
            );
            gamerManager.Add(new Gamer
            {
                Id = 2,
                FirstName = "Ali",
                LastName = "VELİ",
                DateOfBirth = new DateTime(1995, 5, 5),
                NationalityId = "11111111111"
            }
            );
            gamerManager.Update(new Gamer
            {
                Id = 2,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                DateOfBirth = new DateTime(1995, 5, 5),
                NationalityId = "11111111111"
            });
            gamerManager.Delete(new Gamer
            {
                Id = 2,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                DateOfBirth = new DateTime(1995, 5, 5),
                NationalityId = "11111111111"
            });


            gameManager.GameBuying(new Gamer
            {
                Id = 1,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                DateOfBirth = new DateTime(1995, 5, 5),
                NationalityId = "11111111111"
            }, new Game
            {
                Id = 1,
                Name = "Resident evil",
                Price = 100
            },
            new Campaign
            {
                Id = 1,
                Name = "Cadılar Bayramı",
                Description = "Korku oyunları indirimi %50",
                RateOfDiscount = 0.5
            });

            Console.ReadKey();
        }
    }
}
