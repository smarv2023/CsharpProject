using System.Diagnostics.Contracts;

namespace PersonsAndPets;

public class Cat : Pet
{
    public Cat(string petName) : base(petName) {}
    
    public override string MakeNoise()
    {
        return $"Meow meow";
    }
}
