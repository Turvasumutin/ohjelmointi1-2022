﻿Console.Write("sana 1: ");
string sana1 = Console.ReadLine();

Console.Write("sana 2: ");
string sana2 = Console.ReadLine();

if (sana1.Length > sana2.Length)
{
    Console.WriteLine(sana1);
}
else
{
    Console.WriteLine(sana2);
}

if (sana1.Length == sana2.Length)
{
    Console.WriteLine("yhteenlaskettu pituus: " + sana1.Length * 2);
}