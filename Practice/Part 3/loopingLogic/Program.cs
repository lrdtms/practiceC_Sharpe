// See https://aka.ms/new-console-template for more information
// int forLoops = 0;

// do
// {
    
//     forLoops++;
//     Console.WriteLine(forLoops +"i am a for loop");
//     if (forLoops == 30)
//     {
//     break;
//     }
// } while (forLoops < 20);

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7); 
// This codes generates random numbers until it reaches 7 and stops the code 

// Random random = new Random();
// int current = random.Next(1, 11);
// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

//CODING CHALLENGE
//____________________________________________________________

// int heroHealth = 10;
// int monsterHealth = 10;

// while(heroHealth > 0 && monsterHealth >0)
// {
// if (heroHealth == 0 || monsterHealth == 0) break;
//     int heroAttackPower = 0;
//     int monsterAttackPower = 0;
//     Random attack = new();
//     for (int i = 0; i < 2; i++)
//     {
//         heroAttackPower = attack.Next(1,10);
//         monsterAttackPower = attack.Next(1,10);
//     }
// monsterHealth -= heroAttackPower;
// heroHealth -= monsterAttackPower; 
// Console.WriteLine($" The hero attacked {heroAttackPower} and dealt damage to the monster. Monster Health: {monsterHealth}");
// Console.WriteLine($"The monster attacked {monsterAttackPower} and dealth damage to the Hero. Hero Health: {heroHealth}");
// if (monsterHealth <= 0 )
// {
//     Console.WriteLine("The monster is dead");
// }
// else if (heroHealth <= 0)
// {
//     Console.WriteLine("The hero is dead");
// }

// }

// //GIVEN SOLUTION 
// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
