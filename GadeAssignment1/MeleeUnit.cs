﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadeAssignment1
{
    class MeleeUnit : Unit
    {
        // Properties
       
        int PosX { get; set; }
        int PosY { get; set; }

        int health {
            get
            {
                return health;
            }
            set
            {
                health = 100;
            }

        }
        int speed {
            get
            {
                return speed;
            }
            set
            {
                speed = 10;
            }
                }
        int attack {
            get
            {
                return attack;
            }
            set
            {
                attack = 20;
            }
        }
        int attackRange {
            get
            {
                return attackRange;
            }
            set
            {
                attackRange = 1;
            }
        }
        string faction {
            get
            {
                return faction;
            }
            set
            {
                faction = "Melee";
            }
                }
        string symbol = "#";


        // Overriden Methods

        public override void newPosition()
        {
            
        }
        public override void combat()
        {
            
        }
        public override void isInRange()
        {
            if (true)
            {
                combat();
            }

            
        }
        public override void returnPosition()
        {
                
        }
        public override void terminate()
        {
            if (health == 0)
            {
                
            }
        }
    }
}
