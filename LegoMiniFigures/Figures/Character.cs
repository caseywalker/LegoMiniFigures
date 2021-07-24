using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures.Figures
{
  class Character
  {
    public string Name { get; set; }
    public string Hat { get; set; }
    public string Head { get; set; }
    public string Torso { get; set; }
    public string Legs { get; set; }
    public string Accessories { get; set; }
    public Character Opponent { get; set; }

    private int _strength;
    private int _speed;
    private int _health;

    public Character(string name, string hat, string head, string torso, string legs, string accessories)
    {
      Name = name;
      Hat = hat;
      Head = head;
      Torso = torso;
      Legs = legs;
      Accessories = accessories;

      _strength = 10 + Torso.Length;
      _speed = 5 + Legs.Length;
      _health = 100 + Head.Length;
    }

    public void Stats()
    {
      Console.WriteLine($"Character {Name} has a strength of {_strength}, speed rating of {_speed}, and {_health} health.");
    }

    public void Loadout()
    {
      Console.WriteLine($"{Name} is wearing a {Hat} hat, has a {Head} head, {Torso} for a torso, {Legs} for legs, and {Accessories} accessories.");
    }

    public void Jump()
    {
      Random rnd = new Random();
      var jumpHeight = rnd.Next(1, _speed);
      Console.WriteLine($"{Name} jumped {jumpHeight} feet.");
    }

    public void DoubleJump()
    {
      Random rnd = new Random();
      var doubleJumpHeight = rnd.Next(1, _speed) * 2;
      Console.WriteLine($"{Name} double jumped {doubleJumpHeight} feet.");
    }

    public void Attack()
    {
      Random rnd = new Random();
      var attackResult = rnd.Next(1, _strength);
      Console.Write($"{Name} attacks {Opponent.Name} for {attackResult} damage.\n");
    }
    public void TakeDamage()
    {
      throw new NotImplementedException();
    }
    public void Look()
    {
      throw new NotImplementedException();
    }
    public void Move()
    {
      throw new NotImplementedException();
    }

  }
}
