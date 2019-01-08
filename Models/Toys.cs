using cspetshop.Interfaces;

namespace cspetshop.Models
{
  class Toy : IPurchasable
  {
    public bool Squeek { get; set; }
    public bool Stuffed { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string UPC { get; set; }
    public int Quantity { get; set; }

    public Toy(bool sq, bool st, string name)
    {
      Name = name;
      Squeek = sq;
      Stuffed = st;
    }

    public int GetPrice(int q)
    {
      return Price * q;
    }
  }
}