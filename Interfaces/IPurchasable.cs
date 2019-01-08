namespace cspetshop.Interfaces
{
  interface IPurchasable
  {
    int Price { get; set; }
    string UPC { get; set; }
    int Quantity { get; set; }
    int GetPrice(int q);
  }
}