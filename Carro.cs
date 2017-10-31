using System;
using NetOffice.ExcelApi;
using System.IO;
public class Carro
{
    public string Modelo { get; set; }
    public string Ano { get; set; }
    public string Cor { get; set; }
    public int Preco { get; set; }
    public string Vendido { get; set; }

    public void CadastroCarro()
    {
        bool ConverteuPreco = false;
        int p;
        System.Console.WriteLine("Qual o modelo do Carro?");
        Modelo = Console.ReadLine();
        System.Console.WriteLine("Qual o ano de fabricacao?");
        Ano = Console.ReadLine();
        System.Console.WriteLine("Qual a cor ?");
        Cor = Console.ReadLine();
        do
        {

            Console.WriteLine("Qual o Preco do Carro?");
            ConverteuPreco = int.TryParse(Console.ReadLine(), out p);
        } while (!(ConverteuPreco == true));
        Preco = p;

        Opcionais o = new Opcionais();
        o.SelecaoOpcionais();

        Application ex = new Application();
        ex.DisplayAlerts = false;
        ex.Workbooks.Add();
        int cont = 0;

        do
        {
            cont += 1;
        } while (ex.Cells[cont, 1].Value != null); //verifica se a linha ta vazia para incluir os dados

        FileInfo Arquivo = new FileInfo("Carros.csv");

        if (Arquivo.Length == 0)
        {
            ex.Cells[1, 1].Value = "Carro";
            ex.Cells[1, 2].Value = "Ano de fabricacao";
            ex.Cells[1, 3].Value = "Cor";
            ex.Cells[1, 4].Value = "Preco";
            ex.Cells[1, 5].Value = "Vendido";
        }

        ex.Cells[cont, 1].Value = Modelo;
        ex.Cells[cont, 2].Value = Ano;
        ex.Cells[cont, 3].Value = Cor;
        ex.Cells[cont, 4].Value = Preco;
        ex.Cells[cont, 5].Value = Vendido;
        ex.ActiveWorkbook.SaveAs(@"C:\Users\43692939876\Desktop\Projetos\sistema_concessionaria\Carros.csv"); //sem o caminho, ele salva por default nos "MEUS DOCUMENTOS"
        ex.Quit();
        ex.Dispose();
    }
}