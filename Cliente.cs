using System;
public class Cliente
{
    public string Nome { get; set; }
    public string Idade { get; set; }
    public string CPF { get; set; }
    
     public void CadastrarCliente()
    {
        Pessoa p = new Pessoa();

        p.CadastroPessoa();
        
    }







}