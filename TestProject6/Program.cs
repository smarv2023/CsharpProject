Random random = new Random();
int attack = 0;
int heroHp = 10;
int monsterHp = 10;
bool endGame = false;
Console.WriteLine("do While");
do
{
    //Hero attack
    Console.WriteLine($"Hero HP: {heroHp}\nMonster HP: {monsterHp}");
    attack = random.Next(1, 10);
    monsterHp -= attack;
    Console.WriteLine($"Hero Attack: -{attack}\t\tMonster remaining HP: {monsterHp}");
    if (monsterHp <= 0)
    {
        Console.WriteLine(new string('-', 20));
        Console.WriteLine($"Hero wins");
        endGame = true;
        continue;
    }

    //Monster attack
    attack = random.Next(1, 10);
    heroHp -= attack;
    Console.WriteLine($"Monster Attack: -{attack}\tHero remaining HP: {heroHp}");
    if (heroHp <= 0)
    {
        Console.WriteLine(new string('-', 20));
        Console.WriteLine($"Monster wins");
        endGame = true;
        continue;
    }
    Console.WriteLine(new string('-', 20));
} while (!endGame);

// Another version

int hero = 10;
int monster = 10;

Random dice = new Random();
Console.WriteLine(new string('-', 20));
do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");