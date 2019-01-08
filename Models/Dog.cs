namespace cspetshop.Models
{
  class Dog : Animal
  {
    public override void Speak()
    {
      System.Console.WriteLine("WOOF");
    }
    public Dog(string name, int legs, string gender) : base(name, legs, gender)
    {
    }
  }
}