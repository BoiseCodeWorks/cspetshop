using cspetshop.Interfaces;

namespace cspetshop.Models
{
  class Cat : Animal, IPurchasable
  {
    public int Price { get; set; }
    public string UPC { get; set; }
    public int Quantity { get; set; }

    public override void Speak()
    {
      System.Console.WriteLine("Meow?");
    }

    public int GetPrice(int q)
    {
      return P;
    }

    public Cat(string name, int legs, string gender) : base(name, legs, gender)
    {
    }
  }
}