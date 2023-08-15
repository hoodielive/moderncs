Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100));


string message = "Hello, Darling";
string upperMessage = message.ToUpper();
Console.WriteLine(upperMessage);

bool simpleBoolean = true;
if (simpleBoolean) Console.WriteLine("This will print!");
if (!simpleBoolean) Console.WriteLine("This will not!");

int x = 5000;
bool lessThanAMile = x < 5280;

if (lessThanAMile) { Console.WriteLine("This will print too!"); };

int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}

// Play with UnitConverter
UnitConverter FeetToInches1 = new UnitConverter(12);
UnitConverter FeetToInches2 = new UnitConverter(5280);

Console.WriteLine(FeetToInches1.Convert(30));

public class UnitConverter
{
    int ratio;

    public UnitConverter(int unitRatio)
    {
        // I am a constructor
        ratio = unitRatio;
    }

    public int Convert(int unit)
    {
        return unit * ratio;
    }
}


public class Panda
{
    public string Name;
    public static int Population;

    public Panda(string n) // Constructor
    {
        Name = n;
        Population = Population + 1;
    }
}

Panda p1 = new Panda("Glory");
