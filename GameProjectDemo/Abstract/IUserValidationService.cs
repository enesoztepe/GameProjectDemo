using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IUserValidationService
    {
        public bool Validate(Gamer gamer);
    }
}
