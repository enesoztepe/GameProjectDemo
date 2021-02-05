using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth.Year == 2000 && gamer.NationalityId == "11111111111" && 
                gamer.FirstName == "Enes" && gamer.LastName == "ÖZTEPE")
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
