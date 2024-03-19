public class voiturecar
{
    public string Fabrication { get; private set; }
    public string Modele { get; private set; }
    public int Anneefabrication { get; private set; }
    public Colors color { get; private set; }

    public string VoitureCarCar
    {
        get { return $"{Fabrication} {Modele}"; }
    }

    public void DemarrageMoteur()
    {
        Console.WriteLine("VROUMMMMMMMMMMMMMMMMMMMMMMMMMMM");
    }

    public voiturecar(string fabrication, string modele, int anneeFabrication, Colors color)
    {
        Fabrication = fabrication;
        Modele = modele;
        Anneefabrication = anneeFabrication;
        this.color = color;
    }
}
