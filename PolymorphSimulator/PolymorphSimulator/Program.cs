int[] CardsMana = new int[32];
string[] CardsName = new string[32];
CardsMana[1] = 1;
CardsMana[2] = 1;
CardsMana[3] = 3;
CardsMana[4] = 3;
CardsMana[5] = 3;
CardsMana[6] = 3;
CardsMana[7] = 4;
CardsMana[8] = 3;
CardsMana[9] = 7;
CardsMana[10] = 5;
CardsMana[11] = 7;
CardsMana[12] = 1;
CardsMana[13] = 3;
CardsMana[14] = 3;
CardsMana[15] = 7;
CardsMana[16] = 2;
CardsMana[17] = 3;
CardsMana[18] = 2;
CardsMana[19] = 6;
CardsMana[20] = 1;
CardsMana[21] = 1;
CardsMana[22] = 1;
CardsMana[23] = 5;
CardsMana[24] = 2;
CardsMana[25] = 3;
CardsMana[26] = 4;
CardsMana[27] = 10;
CardsMana[28] = 10;
CardsMana[29] = 5;
CardsMana[30] = 7;
CardsMana[31] = 9;
double runs;
Random rng = new Random();
Console.WriteLine("Input the amount of runs.");
runs = Convert.ToDouble(Console.ReadLine());
double masspolymorph = 0;
int value = 20;
double precentage; 
int additionalcasts = 0;
bool anotherone = false;
for (int i = 0; i <= runs; i++)
{
    int rolled;
    int spell;
    Console.WriteLine("Rune of the Archmage #" + i);
    Console.WriteLine("");
    do
    {
        anotherone = false;
        do
        {
            do
            {
                spell = rng.Next(1, 32);
                rolled = CardsMana[spell];
            } while (rolled > value);
            if (spell == 30)
            {
                Console.WriteLine("Opponent casted Mass Polymorph");
                masspolymorph = masspolymorph + 1;
            }
            if (spell == 31)
            {
                Console.WriteLine("Opponent casted another Rune of the Archmage");
                anotherone = true;
                additionalcasts = additionalcasts + 1;
            }
            value = value - rolled;
            Console.WriteLine("Casted a " + rolled + " mana spell.");
        } while (value != 0);
        value = 20;
        Console.WriteLine("");
    } while (anotherone == true);
    
}
Console.WriteLine("In " + runs + " runs, opponent casted a total of " + (runs + additionalcasts) + " Rune of the Archmage. Opponent casted Mass Polymorph " + masspolymorph + " times.");
precentage = masspolymorph / runs * 100;
Console.WriteLine("Opponent casted Mass Polymorph " + Math.Round(precentage, 3) + "% of the times.");
Console.ReadLine();
