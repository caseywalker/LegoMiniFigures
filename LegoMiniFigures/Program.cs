using LegoMiniFigures.Figures;
using System;

namespace LegoMiniFigures
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Lego Minifigures");

      var hulk = new Character("Hulk", "Spartan Helmet", "Green Face", "Gladiator Armor", "Ripped Pants", "War-Axe");
      hulk.Stats();
      hulk.Loadout();
      hulk.Jump();
      hulk.DoubleJump();


      var thor = new Character("Thor", "Asgard Helm", "Eye Patch", "Leather Vest", "Red Kilt", "Mjolnir");
      thor.Stats();
      thor.Loadout();
      thor.Jump();
      thor.DoubleJump();

      hulk.Opponent = thor;
      thor.Opponent = hulk;

      hulk.Attack();
      thor.Attack();


    }
  }
}
