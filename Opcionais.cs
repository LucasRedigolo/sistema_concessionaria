using System;
public class Opcionais
{
    public string ArCond { get; set; }
    public string DirHid { get; set; }
    public string Ambos { get; set; }

    public void SelecaoOpcionais()
    {
        bool Converteu = false;
        int brinde;

        do
        {
            Console.WriteLine("Qual são os opcionais desejados?\n1 Ar Condicionado\n2 Direcao Hidraulica \n3 Ambos");
            Converteu = int.TryParse(Console.ReadLine(), out brinde);
        } while (!(Converteu == true && brinde == 1 || brinde == 2 || brinde == 3));
    }
}