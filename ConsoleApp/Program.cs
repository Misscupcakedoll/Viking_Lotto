using ClassLibrary.Data;
using ClassLibrary.Models;

if (args.Length == 0 || !File.Exists(args[0]))
        {
            Console.WriteLine("Helytelen paraméterezés! A helyes formátum: alkalmazásnév [állomány útvonala]");
           // return; A tesztelés miatt kommenteztem ki a kilépést
        }

else
{
    Console.WriteLine("Az állomány megtalálva: " + args[0]);
}
        


Adatbazis db = new Adatbazis();
if (!db.Huzas.Any())
{
    string[] sorok = File.ReadAllLines(@"C:\adat\VikingLottoSzamok.csv");

    foreach (var sor in sorok)
    {
        Huzas huzas = new Huzas();
        Boolean oks = true;
        try
        {
            huzas = new Huzas(sor);
        }
        catch
        {
            Console.WriteLine("Hibás sor: " + sor);
            oks = false;
        }
        if (oks)
        {
            db.Huzas.Add(huzas);
        }

    }
    db.SaveChanges();

    foreach (var item in db.Huzas)
    {
        Console.WriteLine(item);
    }
}

