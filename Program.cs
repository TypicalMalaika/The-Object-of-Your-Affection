using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "He/him");
      sam.SetHobbies(new string[] {"writing a speculative fiction novel", "playing rec sports like bowling and kickball", "writing a speculative fiction nove", "reading advice columns"});
      Console.WriteLine(sam.ViewProfile());
    }
  }
}
