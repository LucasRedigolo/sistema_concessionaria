using System;
using NetOffice.ExcelApi;
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
                ex.Workbooks.Add();
                ex.Cells[1, 1].Value = "Nome";
                ex.Cells[1, 2].Value = "Idade";
                ex.Cells[1, 3].Value = "CPF";
                ex.Cells[1, 4].Value = "Logradouro";
                ex.Cells[1, 5].Value = "Numero";
                ex.Cells[2, 1].Value = Nome;
                ex.Cells[2, 2].Value = Idade;
                ex.Cells[2, 3].Value = CPF;
                ex.Cells[2, 4].Value = e.Logradouro;
                ex.Cells[2, 5].Value = e.Numero;
                ex.ActiveWorkbook.SaveAs(@"C:\Users\43692939876\Desktop\Projetos\sistema_concessionaria\Clientes.csv"); //sem o caminho, ele salva por default nos "MEUS DOCUMENTOS"
                ex.Quit();
                ex.Dispose();
            }
        }while(cpfvalido == false);
    }
}

     


