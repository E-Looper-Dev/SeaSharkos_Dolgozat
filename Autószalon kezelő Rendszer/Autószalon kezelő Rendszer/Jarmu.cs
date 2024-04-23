using System;

public class Jarmu
{
	public string Gyarto { get; set; }
	public string Modell { get; set; }
	public int Evjarat { get; set; }
	public int AlapAr { get; set; }
	public Jarmu(string gyarto, string modell, int evjarat, int alapAr)
	{
		Gyarto = gyarto;
		Modell = modell;
		Evjarat = evjarat;
		AlapAr = alapAr;
	}
	public void JarmuInfo()
	{
		Console.WriteLine($"Gyártó: {Gyarto}, Modell: {Modell}, Évjárat: {Evjarat}");
	}
	public int ArKalkulacio()
	{
		int aktualisAr = AlapAr - (DateTime.Now.Year - Evjarat) * 1000;
		return aktualisAr;
	}
}
