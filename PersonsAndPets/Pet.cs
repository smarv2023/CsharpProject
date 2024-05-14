namespace PersonsAndPets;

/* public abstract class Pet(string petName)
{
    public string PetName { get; set; } = petName;
    // {
    //     get { return petName; }
    // }

    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"{PetName} and I am a {GetType().Name} and I make {MakeNoise()} sound";
    }
}
 */

 public abstract class Pet
{
    public string PetName { get; } // Property to store the name of the pet

    // Constructor to initialize the PetName property
    public Pet(string petName)
    {
        PetName = petName;
    }

    // Abstract method to be implemented by derived classes
    public abstract string MakeNoise();

    // Override method to provide custom string representation of the pet
    public override string ToString()
    {
        return $"{PetName} and I am a {GetType().Name} and I make {MakeNoise()} sound";
    }
}
