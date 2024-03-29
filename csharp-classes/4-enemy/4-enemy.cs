﻿using System;

namespace Enemies
{
    /// <summary>Defines a Zombie</summary>
    public class Zombie
    {
        /// <summary>Represents Zombies Health</summary>
        private int health;
        /// <summary>Zombies Name</summary>
        private string name = "(No name)";

        /// <summary>Zombie Constructor</summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>Zombie Constructor with int param</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }

        /// <summary>returns health of the zombie</summary>
        public int GetHealth()
        {
            return this.health;
        }

        /// <summary>Property for get and set name</summary>
        public string Name
        {
            get {return this.name;}
            set {this.name = value;}
        }
    }
}