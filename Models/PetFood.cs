using cspetshop.Interfaces;

namespace cspetshop.Models
{
  class PetFood : IPurchasable
  {
    public int Weight { get; set; }
    public string Brand { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string UPC { get; set; }
    public int Quantity { get; set; }

    public PetFood(int w, string b, string name)
    {
      Weight = w;
      Brand = b;
      Name = name;
    }

    public int GetPrice(int q)
    {
      return Price * q;
    }
  }
}