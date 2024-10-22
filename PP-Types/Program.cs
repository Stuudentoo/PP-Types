// Write required code.

// Data - do not change it in code!
string[] names = {
    "Mickey Mouse", "Minnie Mouse", "Donald Duck", "Goofy", "Pluto", "Daisy Duck", "Simba", "Nala",
    "Timon", "Pumbaa", "Mufasa", "Ariel", "Flounder", "Sebastian", "Ursula", "Belle", "Beast", "Gaston",
    "Cinderella", "Prince Charming", "Aurora", "Maleficent", "Rapunzel", "Flynn Rider", "Elsa", "Anna",
    "Olaf", "Moana", "Maui", "Hercules"
};


// Print all array elements, *perLine* elements per one line
// After all elements except last one should be ", " - also on the end of lines.
// After last element should be ".".
void PrintGroups(string[] t, int perLine)
{

    int counter = 1;
    for (int i = 0; i < names.Length; i++, counter++)
    {
        if (counter == 1)
        {
            Console.Write($"\n{names[i]},");
        }
       if (counter>1 && counter<perLine)
        {
            Console.Write($" {names[i]}, ");
        }
        if (counter == perLine)
        {
            counter = 0;
            Console.Write($"{names[i]}.");
        }
    }   
}


// Print all array elements in *perLine* columns.
// Each column must have given *width* (number of chars).
// Columns should be separated by "| ".
// If element is too long it should be trimmed.

void PrintColumns(string[] t, int perLine, int width)
{
    string a = "";
    int b = 0;

    int counter = 1;
    for (int i = 0; i < names.Length; i++, counter++)
    {
        if (counter == 1)
        {
            if (names[i].Length == width)
            {
                Console.Write($"\n{names[i]}|");
            }
            if ((names[i].Length) > width)
            {
                for (b = 0; b < width; b++)
                {
                    a += names[i][b];
                }
                Console.Write($"\n{a}|");
                a = "";
            }
            if (names[i].Length < width)
            {
                a = names[i];
                for (b = 0; b <= width - names[i].Length - 1; b++)
                {
                    a += " ";
                }
                Console.Write($"\n{a}|");
                a = "";
            }
        }
        if (counter > 1 && counter < perLine)
        {
            if (names[i].Length == width)
            {
                Console.Write($" {names[i]}|");
            }
            if ((names[i].Length) > width)
            {
                for (b = 0; b < width; b++)
                {
                    a += names[i][b];
                }
                Console.Write($" {a}|");
                a = "";
            }
            if (names[i].Length < width)
            {
                a = names[i];
                for (b = 0; b <= width - names[i].Length - 1; b++)
                {
                    a += " ";
                }
                Console.Write($" {a}|");
                a = "";
            }
        }

        if (counter == perLine)
        {
            if (names[i].Length == width)
            {
                Console.Write($" {names[i]}");
            }
            if ((names[i].Length) > width)
            {
                for (b = 0; b < width; b++)
                {
                    a += names[i][b];
                }
                Console.Write($" {a}");
                a = "";
            }
            if (names[i].Length < width)
            {
                a = names[i];
                for (b = 0; b <= width - names[i].Length - 1; b++)
                {
                    a += " ";
                }
                Console.Write($" {a}");
                a = "";
            }
            counter = 0;
        }
    }

}


// Test how your functions work. 
// You can temprary comment some lines not needed for current testing.


Console.WriteLine("\nPrintGroups(names, 3):\n");
PrintGroups(names, 3);
/*
Mickey Mouse, Minnie Mouse, Donald Duck,
Goofy, Pluto, Daisy Duck,
Simba, Nala, Timon,
Pumbaa, Mufasa, Ariel,
Flounder, Sebastian, Ursula,
Belle, Beast, Gaston,
Cinderella, Prince Charming, Aurora,
Maleficent, Rapunzel, Flynn Rider,
Elsa, Anna, Olaf,
Moana, Maui, Hercules.
*/

Console.WriteLine("\nPrintGroups(names, 5):\n");
PrintGroups(names, 5);
/*
Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto,
Daisy Duck, Simba, Nala, Timon, Pumbaa,
Mufasa, Ariel, Flounder, Sebastian, Ursula,
Belle, Beast, Gaston, Cinderella, Prince Charming,
Aurora, Maleficent, Rapunzel, Flynn Rider, Elsa,
Anna, Olaf, Moana, Maui, Hercules. 
*/

Console.WriteLine("\nPrintGroups(names, 7):\n");
PrintGroups(names, 7);
/*
Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto, Daisy Duck, Simba,
Nala, Timon, Pumbaa, Mufasa, Ariel, Flounder, Sebastian,
Ursula, Belle, Beast, Gaston, Cinderella, Prince Charming, Aurora,
Maleficent, Rapunzel, Flynn Rider, Elsa, Anna, Olaf, Moana,
Maui, Hercules.
*/

// For width = 40 don't worry if result will be wrapped due to screen width.
Console.WriteLine("\nPrintGroups(names, 40):\n");
PrintGroups(names, 40);
/*
Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto, Daisy Duck, Simba, Nala, Timon, Pumbaa, Mufasa, Ariel, Flounder,
Sebastian, Ursula, Belle, Beast, Gaston, Cinderella, Prince Charming, Aurora, Maleficent, Rapunzel, Flynn Rider, Elsa, A
nna, Olaf, Moana, Maui, Hercules.
*/

Console.WriteLine("\n\nPrintColumns(names, 4, 17):\n");
PrintColumns(names, 4, 17);
/*
Mickey Mouse     | Minnie Mouse     | Donald Duck      | Goofy
Pluto            | Daisy Duck       | Simba            | Nala
Timon            | Pumbaa           | Mufasa           | Ariel
Flounder         | Sebastian        | Ursula           | Belle
Beast            | Gaston           | Cinderella       | Prince Charming
Aurora           | Maleficent       | Rapunzel         | Flynn Rider
Elsa             | Anna             | Olaf             | Moana
Maui             | Hercules         |
*/

Console.WriteLine("\n\nPrintColumns(names, 5, 15):\n");
PrintColumns(names, 5, 15);
/*
Mickey Mouse   | Minnie Mouse   | Donald Duck    | Goofy          | Pluto
Daisy Duck     | Simba          | Nala           | Timon          | Pumbaa
Mufasa         | Ariel          | Flounder       | Sebastian      | Ursula
Belle          | Beast          | Gaston         | Cinderella     | Prince Charming
Aurora         | Maleficent     | Rapunzel       | Flynn Rider    | Elsa
Anna           | Olaf           | Moana          | Maui           | Hercules
*/

Console.WriteLine("\n\nPrintColumns(names, 7, 10):\n");
PrintColumns(names, 8, 10);
/*
Mickey Mou| Minnie Mou| Donald Duc| Goofy     | Pluto     | Daisy Duck| Simba     | Nala
Timon     | Pumbaa    | Mufasa    | Ariel     | Flounder  | Sebastian | Ursula    | Belle
Beast     | Gaston    | Cinderella| Prince Cha| Aurora    | Maleficent| Rapunzel  | Flynn Ride
Elsa      | Anna      | Olaf      | Moana     | Maui      | Hercules  |
*/