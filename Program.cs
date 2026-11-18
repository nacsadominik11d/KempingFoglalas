using KempingFoglalas;

List<Foglalas> foglalasok = new List<Foglalas>();

string[] beolvas = File.ReadAllLines("Kemping.txt");

foreach (string sor in beolvas)
{
    Foglalas foglalas = new Foglalas(sor);
    foglalasok.Add(foglalas);
}

Console.WriteLine("Összesített Statisztika:");

