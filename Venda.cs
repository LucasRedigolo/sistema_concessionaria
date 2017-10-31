using System;
using NetOffice.ExcelApi;
public class Venda
{
    public string compra { get; set; }
    public void SelecionarCliente()
    {
        
    }
    public void ListarVenda()
    {
        int cont = 0;

        Application ex = new Application();
        ex.Workbooks.Open(@"C:\Users\43692939876\Desktop\Projetos\sistema_concessionaria\Carros.csv");
        do
        {
            cont += 1;
            if (ex.Cells[cont, 5].Value == null)//Checa se na coluna de carro vendido contem algo
            {
                for (int i = 1; i < 5; i++) // se não conter (carro disponivel) ele escreve a linha inteira do carro
                {
                    Console.Write(ex.Cells[cont, i].Value + " ");
                }
            }   

        } while (ex.Cells[cont, 1].Value != null);

        System.Console.WriteLine("Digite o nome do carro que você quer comprar:");
        compra = Console.ReadLine();

        if (ex.Cells[cont, cont].Value == compra)
        {
            
        }
        
    }
}