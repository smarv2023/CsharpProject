namespace PersonsAndPets;

public class Person(string firstName, string lastName, int age)
{
    public string FirstName { get; set; } = firstName;

    public string LastName { get; set; } = lastName;

    public int Age
    {
        get { return age; }
        set { age = value; }    
    }

    private List<Pet> _pets = new List<Pet>();
    public List<Pet> Pets //{ get; } = new(); //short version
    { 
        get { return _pets; }
    }

    public override string ToString()
    {
        return $"My name is {FirstName} {LastName} and I am {Age}";
    }
}
