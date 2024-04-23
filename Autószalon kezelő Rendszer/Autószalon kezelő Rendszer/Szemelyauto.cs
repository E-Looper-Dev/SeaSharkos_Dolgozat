using System;

public class Szemelyauto : Jarmu
{
	public int UlesekSzama { get; set; }
	public double Fogyasztas { get; set; }
	public Szemelyauto(string gyarto, string modell, int evjarat, int alapAr, int ulesekSzama, double fogyasztas)
		: base(gyarto, modell, evjarat, alapAr)
	{
		UlesekSzama = ulesekSzama;
		Fogyasztas = fogyasztas;
	}
	public void KenyelmiExtraBeszerzese(string extra)
	{
		int extraAr = 1000;
		AlapAr += extraAr;
		Console.WriteLine($"Hozzáadva: {extra}. Új ár: {AlapAr}");
	}
}
