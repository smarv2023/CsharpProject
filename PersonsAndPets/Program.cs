using PersonsAndPets;

Person p1 = new Person("Marv", "Sor", 30);
var p2 = new Person("Liz", "San", 29);

p1.Pets.Add(new Dog("Doggo"));
p1.Pets.Add(new Dog("Bingo"));
p2.Pets.Add(new Cat("Cato"));
p2.Pets.Add(new Cat("Rain"));

// another way of adding to List of pet
Dog potchoy = new Dog("Potchoy");
p1.Pets.Add(potchoy);
potchoy.PetName = "Tirso";

Cat carding = new Cat("Carding");
p2.Pets.Add(carding);
// It will not allowed by Cat class set is not enable in Properties
//carding.PetName = "Jorge";


List<Person> pList = [p1, p2];

foreach (Person person in pList)
{
    Console.WriteLine(person);
    foreach (Pet pets in person.Pets)
    {
        Console.WriteLine($"        {pets}");
    }
}
