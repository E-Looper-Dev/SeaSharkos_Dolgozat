using System;

public class Terepjaro : Jarmu
{
	public string Hajtas { get; set; }
	public bool OffroadKepessegek { get; set; }
	public Terepjaro(string gyarto, string modell, int evjarat, int alapAr, string hajtas)
		: base(gyarto, modell, evjarat, alapAr)
	{
		Hajtas = hajtas;
		OffroadKepessegek = false;
	}
	public void OffroadCsomagFelszerel()
	{
		int offroadCsomagAr = 3000;	
		AlapAr += offroadCsomagAr;
		OffroadKepessegek = true;
		Console.WriteLine("Offroad csomag felszerelve. Új ár: " + AlapAr);
	}
}
