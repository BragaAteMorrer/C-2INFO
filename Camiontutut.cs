using System;
using System.Collections.Generic;

public class Camiontutut : voiturecar
{
    public int ChargeMax { get; set; }
    public int ChargeActuelle { get; private set; }
    public List<Colis> ColisList { get; set; }

    private int GetChargeActuelle()
    {
        int chargeActuelle = 0;
        foreach (var colis in ColisList)
        {
            chargeActuelle += colis.Poids;
        }
        return chargeActuelle;
    }

    public Camiontutut(string fabrication, string modele, int anneeFabrication, Colors color, int chargeMax, int chargeActuelle)
        : base(fabrication, modele, anneeFabrication, color)
    {
        ChargeMax = chargeMax;
        ChargeActuelle = chargeActuelle;
        ColisList = new List<Colis>();
    }

    public void addChargement(List<Colis> colisList)
    {
        int poidsTotal = GetChargeActuelle();
        foreach (var colis in colisList)
        {
            poidsTotal += colis.Poids;
        }

        if (poidsTotal > ChargeMax)
        {
            Console.WriteLine("Le camion est trop lourd");
        }
        else
        {
            foreach (var colis in colisList)
            {
                ColisList.Add(colis);
            }
            Console.WriteLine("ALLEZ MARCEL *Musique de c'est pas sorcier*");
        }
    }
}