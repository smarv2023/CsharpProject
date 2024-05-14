using System.Diagnostics.Contracts;
using System.Security.Cryptography;

namespace PersonsAndPets;

public class Dog(string petName) : Pet(petName)
{
    public string PetName { get; set; } = petName;

    public override string MakeNoise()
    {
        return "Bark bark";
    }
}

/* 
 public class Dog : Pet
{
    public Dog(string petName) : base(petName){}

    public override string MakeNoise()
    {
        return $"Bark bark";
    }
} 
 */