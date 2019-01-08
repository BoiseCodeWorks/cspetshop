using System.Collections.Generic;
using cspetshop.Interfaces;

namespace cspetshop.Models
{
  class PetShop
  {
    public string Name { get; set; }
    public Dictionary<string, List<Animal>> Pets { get; private set; }

    public List<IPurchasable> Inventory { get; set; }


    public void AddPet(string type, Animal pet)
    {
      if (!Pets.ContainsKey(type))
      {
        Pets.Add(type, new List<Animal>());
      }
      Pets[type].Add(pet);
    }


    public void PrintType(string type)
    {
      if (Pets.ContainsKey(type))
      {
        System.Console.WriteLine(type.ToUpper());
        Pets[type].ForEach(pet =>
        {
          System.Console.WriteLine(pet.Name);
        });
      }
    }
    public PetShop(string name)
    {
      Name = name;
      Pets = new Dictionary<string, List<Animal>>();
    }
  }
}