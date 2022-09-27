// Antud projekt on loodud Boriss Errapart poolt, rühmast KK2020
// Rakendus küsib kasutajalt tema nime.
// Rakendus tervitab kasutajat nimepidi.


Console.WriteLine("Sisesta oma nimi:");
// string - sõne
string userName;
// kuidas ma loen kasutaja nime. Eelmise ja järgmise rea saab ka kokku tõmmata ühele reale.
userName = Console.ReadLine();
// Rakendus tervitab kasutajat nimepidi
Console.WriteLine("Tere" + ", " + userName + "!");
// String interpolation (katse 2) dollari märk annab teada, et kasutad muutujat, dollari märk on: alt(parem) + 4, erimärgid: alt + 7.
Console.WriteLine($"Tere, {userName} Errapart!");