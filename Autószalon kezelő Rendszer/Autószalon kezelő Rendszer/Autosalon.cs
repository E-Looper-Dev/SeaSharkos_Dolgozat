using System;
using System.Collections.Generic;

public class Autosalon
{
	public List<Jarmu> Jarmuvek { get; set; }
	public Autosalon()
	{
		Jarmuvek = new List<Jarmu>();
	}
	public void UjJarmuHozzaadasa(Jarmu jarmu)
	{
		Jarmuvek.Add(jarmu);
		Console.WriteLine("Új jármű hozzáadva a készlethez.");
	}
	public void JarmuEladasa(string gyarto, string modell)
	{
		Jarmu eladandoJarmu = Jarmuvek.Find(j => j.Gyarto == gyarto && j.Modell == modell);
		if (eladandoJarmu != null)
		{
			Jarmuvek.Remove(eladandoJarmu);
			Console.WriteLine($"{gyarto} {modell} eladva.");
		}
		else
		{
			Console.WriteLine("Nincs ilyen jármű a készleten.");
		}
	}
	public void JarmuvekListazasa()
	{
		Console.WriteLine("Elérhető járművek a készletben:");
		foreach (Jarmu jarmu in Jarmuvek)
		{
			jarmu.JarmuInfo();
		}
	}
}
