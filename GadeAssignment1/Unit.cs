using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadeAssignment1
{
    abstract class Unit
    {

        // Properties

        int PosX { get; set; }
        int PosY { get; set; }
        int health { get; set; }
        int speed { get; set; }
        int attack { get; set; }
        int attackRange { get; set; }
        string faction { get; set; }
        string symbol = "#";

        public Unit()
        {

        }

        // Virtual Methods

        virtual public void newPosition() { }
        virtual public void combat() { }
        virtual public void isInRange() { }
        virtual public void returnPosition() { }
        virtual public void terminate() { }
        
        // Show unit information

        public override string ToString()
        {
           return "health = " + health
                + "\n" + "speed = " + speed 
                + "\n" + "attack = " + attack 
                + "\n" + "attack range =" + attackRange 
                + "\n" + "faction =" + faction;
        }
    }
    
}
