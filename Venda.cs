using System;
using NetOffice.ExcelApi;
public class Venda
{
    public void ListarVenda()
    {
        int cont = 0;

        Application ex = new Application();
        ex.Workbooks.Open(@"C:\Users\43692939876\Desktop\Projetos\sistema_concessionaria\Carros.csv");
        do
        {
            cont += 1;
            if (ex.Cells[cont, 5].Value == null)
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.Write(ex.Cells[cont, i].Value + " ");
                }
            }

        } while (ex.Cells[cont, 1].Value != null);
    }
}