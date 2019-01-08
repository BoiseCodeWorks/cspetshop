namespace cspetshop.Models
{
  abstract class Animal
  {
    public string Name { get; set; }
    public int Legs { get; set; }
    public string Gender { get; set; }

    public virtual void Speak()
    {
      System.Console.WriteLine("????");
    }

    public Animal(string name, int legs, string gender)
    {
      Name = name;
      Legs = legs;
      Gender = gender;
    }
  }
}