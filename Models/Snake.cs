namespace cspetshop.Models
{
  class Snake : Animal
  {
    public override void Speak()
    {
      System.Console.WriteLine("SSSSSSS_ssss_SSSSS_sssss");
    }
    public Snake(string name, int legs, string gender) : base(name, legs, gender)
    {
    }
  }
}