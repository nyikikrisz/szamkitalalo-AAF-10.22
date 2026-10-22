using System.ComponentModel.DataAnnotations;

Console.WriteLine("Üdvözöllek a számkitalálós játéban!");
Console.WriteLine("Találd ki a számot 0 és 100 között");
int kozelseg;
string tobbkevesebb;
char billentyu = 'n';
bool meg = false;
int max = 10000;

do
{
	Console.WriteLine("Itt látod a színkódokat és hogy hány szám távolságra tippeltél kb.");
	Konzol.messze("╔══════════════════════╗");
	Konzol.messze("║      messze (50)     ║");
	Konzol.kozelebb("║     kozelebb (25)    ║");
	Konzol.kozel("║      kozel (15)      ║");
	Konzol.nagyonkozel("║   nagyonkozel (<15)  ║");
	Konzol.megvan("║        megvan        ║");
	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine("      ╚══════════════════════╝      ");
	Console.ResetColor();

	int szam = Random.Shared.Next(0, 101);

	Console.Write("Első Tipp:");
	int tipp = int.Parse(Console.ReadLine());
	int szamlalo = 1;
	Console.WriteLine("-------------Következő tipp-------------\n\n\n\n");

	if (tipp == szam)
		Konzol.megvan($"Gratulálunk elsőre kitaláltad ez inkább szerencse mint tudás!! A szamod: {szam}");

	do
	{
		if (0 <= tipp && tipp <= 100)
		{
			kozelseg = szam - tipp;
			if (kozelseg < 0)
				kozelseg *= -1;


			if (tipp < szam)
				tobbkevesebb = " A keresett szám |Több| (mint a tipped)";
			else
				tobbkevesebb = "A keresett szám |Kevesebb|  (mint a tipped)";


			if (kozelseg > 50)
				Konzol.messze($"(Ez még elég messze van) ═══ {tobbkevesebb} ═══");

			else if (kozelseg > 25)
				Konzol.kozelebb($"(Melegszik!) ═══ {tobbkevesebb} ═══");

			else if (kozelseg > 15)
				Konzol.kozel($"(Ez már elég közel van) ═══ {tobbkevesebb} ═══");

			else
				Konzol.nagyonkozel($"(Ez már nagyon közel van) ═══ {tobbkevesebb} ═══");


		}

		else
			Konzol.hiba("Hiba: A számod nem lehet 0-nál kisebb vagy 100-nál nagyobb");

		Console.Write("Tipp:");
		tipp = int.Parse(Console.ReadLine());
		szamlalo += 1;
		Console.WriteLine("-------------Következő tipp-------------\n\n\n\n");
	} while (tipp != szam);

	Konzol.megvan($"         Gratulálunk!!! Kitaláltad a számod: {szam}           tippeléseid száma: {szamlalo}         ");
	if (szamlalo < max)
		Konzol.megvan("!!!!!!!!!   Új rekord    !!!!!!!!!");

	Console.WriteLine("szeretnél megegyet játszani? (i/n)");
	ConsoleKeyInfo gomb = Console.ReadKey();
	billentyu=char.ToUpper(gomb.KeyChar);
	switch (billentyu)
	{
		case 'I':
			meg=true;
			break;

		default:
			meg=false;
			break;
	}
	Console.Clear();

	if (szamlalo > max)
		max=szamlalo;

} while (meg == true);