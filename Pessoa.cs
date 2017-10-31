using System;
using NetOffice.ExcelApi;
using System.IO;
public class Pessoa
{
    public string Nome { get; set; }
    public string Idade { get; set; }
    public string CPF { get; set; }

    public void CadastroPessoa()
    {
        bool cpfvalido = true;

        System.Console.WriteLine("Qual o seu Nome?");
        Nome = Console.ReadLine();
        System.Console.WriteLine("Qual sua idade?");
        Idade = Console.ReadLine();

        do
        {
            System.Console.WriteLine("Qual o seu CPF?");
            CPF = Console.ReadLine();
            ValidacaoCPF v = new ValidacaoCPF();
            cpfvalido = v.checagemcpf(CPF);

            if (cpfvalido == true)
            {
                Endereco e = new Endereco();
                e.CadastrarEndereco();

                Application ex = new Application();
                ex.DisplayAlerts = false;
                ex.Workbooks.Add();
                int contador = 0;

                do
                {
                    contador += 1;
                } while (ex.Cells[contador, 1].Value != null);

                FileInfo Arquivo = new FileInfo("Carros.csv");

                if (Arquivo.Length == 0)
                {
                    ex.Cells[1, 1].Value = "Nome";
                    ex.Cells[1, 2].Value = "Idade";
                    ex.Cells[1, 3].Value = "CPF";
                    ex.Cells[1, 4].Value = "Logradouro";
                    ex.Cells[1, 5].Value = "Numero";
                }
                    ex.Cells[contador, 1].Value = Nome;
                    ex.Cells[contador, 2].Value = Idade;
                    ex.Cells[contador, 3].Value = CPF;
                    ex.Cells[contador, 4].Value = e.Logradouro;
                    ex.Cells[contador, 5].Value = e.Numero;
                    ex.ActiveWorkbook.SaveAs(@"C:\Users\43692939876\Desktop\Projetos\sistema_concessionaria\Clientes.csv"); //sem o caminho, ele salva por default nos "MEUS DOCUMENTOS"
                    ex.Quit();
                    ex.Dispose();
                }
            } while (cpfvalido == false) ;
        }
}




