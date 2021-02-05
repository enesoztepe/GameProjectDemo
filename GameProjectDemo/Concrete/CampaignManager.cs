using System;
using GameProjectDemo.Abstract;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public  class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni kampanya eklenmiştir.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli kampanya silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli kampanya bilgileri güncellenmiştir.");
        }
    }
}
