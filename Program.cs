using System;
using System.Collections.Generic;
using cspetshop.Models;

namespace cspetshop
{
  class Program
  {
    static void Main(string[] args)
    {
      //Initialize data
      PetShop myShop = new PetShop("Mark's Elite Pups and Paws");
      Dog bingo = new Dog("bingo", 4, "male");
      Dog lucky = new Dog("lucky", 3, "female");
      Cat mrSnibbley = new Cat("Mr. Snibbley", 4, "male");
      Snake hiss = new Snake("Sir Hiss", 0, "male");
      Snake ka = new Snake("Ka", 0, "female");

      //Add pets to shop
      myShop.AddPet("dog", bingo);
      myShop.AddPet("dog", lucky);
      myShop.AddPet("cat", mrSnibbley);
      myShop.AddPet("snake", hiss);
      myShop.AddPet("snake", ka);

      Console.Clear();
      Console.WriteLine("Welcome to my PetShop");

      //Itterate over key value pairs (pair) in the Pets dictionary (myShop.pets)
      foreach (var pair in myShop.Pets)
      {
        //Print the name of the pet type (pair.Key)
        System.Console.WriteLine(pair.Key + "s");
        //for each value (pair.Value) itterate over the list of pets
        pair.Value.ForEach(pet =>
        {
          System.Console.WriteLine(pet.Name);
        });
      }

      myShop.PrintType("dog");

    }
  }
}

