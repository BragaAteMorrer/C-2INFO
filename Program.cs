internal class Program
{
    private static void Main(string[] args)
    {
        voiturecar deuxcentcinq = new voiturecar("Peugeot", "205GTI 1.9L", 1984, Colors.rouge);
        Camiontutut scania = new Camiontutut("Scania", "V8", 2018, Colors.gris, 1200, 0);
        Colis colis1 = new Colis(1, 500, false);
        Colis colis2 = new Colis(2, 120, false);
        Colis colis3 = new Colis(3, 342, false);

        Console.WriteLine($"La Voiture de Michel est une : {deuxcentcinq.VoitureCarCar} Fabriqué en {deuxcentcinq.Anneefabrication}");
        deuxcentcinq.DemarrageMoteur();

        Console.WriteLine($"C'est un {scania.VoitureCarCar}, il est de {scania.Anneefabrication} mon camion peut prendre {scania.ChargeMax} tonnes soit le poids de ta grosse daronne");
        scania.DemarrageMoteur();

        List<Colis> colisList = new List<Colis> { colis1, colis2, colis3 };
        scania.addChargement(colisList);
    }
}
