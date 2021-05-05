using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGameNetCore.Models
{
    public class Unit
    {
        public string Name;
        public int Health;
        public string AvatarURL;

        public Unit(string name, int health, string avatarURL)
        {
            Name = name;
            Health = health;
            AvatarURL = avatarURL;
        }
    }
}
