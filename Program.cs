/*Feed the Neighborhood Project Conversions
1 sandwich = 1 person
1 Sandwich = 2 slices of bread, 2 tbsp of pb, and 4 tsp of jelly
1 loaf of bread = 28 slices
1 jar of pb = 32 tbsp
1 jar of jelly = 48 tsp*/

/*Declare variables to be used*/
/*This defines units per jar/loaf*/
int slicesperloaf = 28;
int tbspperjarofPB = 32;
int tspperjarofJelly = 48;
string answer;

/*Loop starts here*/
do
{ 
    /*Ask for input of how many people there are*/
    Console.WriteLine("How many people are you feeding?");
    int people = int.Parse(Console.ReadLine());

    /*This calculates units needed*/
    int totalSlicesNeeded = people * 2;
    int totalTbspofPbNeeded = people * 2;
    int totaltspofJellyNeeded = people * 4;

    /*This converts units needed to loaves/jars needed
    These need to be whole numbers*/
    /*I may be able to use "Math.Ceiling" here*/
    int totalloavesNeeded = totalSlicesNeeded / slicesperloaf;
    int totaljarsofpbNeeded = totalTbspofPbNeeded / tbspperjarofPB;
    int totaljarsofjellyNeeded = totaltspofJellyNeeded / tspperjarofJelly;

    /*This outputs the unit calculations*/
    Console.WriteLine(@"
    If eveyone eats one sandwich, you will need:
    ");
    Console.WriteLine("     " + totalSlicesNeeded + " slices of bread");
    Console.WriteLine("     " + totalTbspofPbNeeded + " tablespoons of peanut butter");
    Console.WriteLine("     " + totaltspofJellyNeeded + " teaspoons of jelly");

    Console.WriteLine(@"

    which is...

    ");

    /*This outputs the loaf/jar calculations*/
    Console.WriteLine("     " + totalloavesNeeded + " loaves of bread");
    Console.WriteLine("     " + totaljarsofpbNeeded + " jars of peanut butter");
    Console.WriteLine("     " + totaljarsofjellyNeeded + " jars of jelly");

    Console.WriteLine(@"
    Would you like to restart? 
    Enter yes or y to continue, 
    or enter any other key to exit.");

    answer = Console.ReadLine();

} while (answer=="yes" || answer=="y");

Console.WriteLine("Goodbye!");