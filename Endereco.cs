using System;
public class Endereco
{
    public string Logradouro { get; set; }
    public string Numero { get; set; }

    public void CadastrarEndereco()
    {
        System.Console.WriteLine("Qual sua Rua/Avenida?");
        Logradouro = Console.ReadLine();
        System.Console.WriteLine("Qual numero?");
        Numero = Console.ReadLine();
    }
}