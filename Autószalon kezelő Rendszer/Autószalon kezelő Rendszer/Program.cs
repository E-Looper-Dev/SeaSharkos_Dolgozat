using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autószalon_kezelő_Rendszer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Jarmu jarmu = new Jarmu("BMW", "X5", 2020, 8000000);
			jarmu.JarmuInfo();
			Console.WriteLine($"Aktuális ár: {jarmu.ArKalkulacio()}");
			Szemelyauto szemelyauto = new Szemelyauto("Toyota", "Corolla", 2019, 20000, 5, 6.5);
			szemelyauto.KenyelmiExtraBeszerzese("Navigációs rendszer");
			Terepjaro terepjaro = new Terepjaro("Jeep", "Wrangler", 2022, 35000, "4x4");
			terepjaro.OffroadCsomagFelszerel();
			Autosalon autosalon = new Autosalon();
			autosalon.UjJarmuHozzaadasa(new Jarmu("BMW", "X5", 2020, 8000000));
			autosalon.UjJarmuHozzaadasa(new Jarmu("Toyota", "Corolla", 2019, 20000));
			autosalon.JarmuvekListazasa();
			Console.WriteLine("\nToyota Corolla eladása...");
			autosalon.JarmuEladasa("Toyota", "Corolla");
			Console.WriteLine("\nFrissített járművek a készletben:");
			autosalon.JarmuvekListazasa();
		}
	}
}
