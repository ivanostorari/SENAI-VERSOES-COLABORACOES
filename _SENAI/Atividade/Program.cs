using System;
namespace Atividade 
{
    class Program
    {
      static void Main(string[] args)
      {
       float val_pag;
       Console.WriteLine("Informar Nome");
       string var_nome = Console.ReadLine();
       Console.WriteLine("Informar Endereco");
       string var_endereco = Console.ReadLine();
       Console.WriteLine("Pessoa fisica (f) ou Juridica (j)?");
       string var_tipo = Console.ReadLine();
       if(var_tipo == "f")
       {
          //--- Pessoa Fisica --- 
           Pessoa_Fisica pf = new Pessoa_Fisica();
           pf.nome = var_nome;
           pf.endereco = var_endereco;
           Console.WriteLine("Informar CPF:");
           pf.cpf = Console.ReadLine();
           Console.WriteLine("Informar RG:");
           pf.rg = Console.ReadLine();
           Console.WriteLine("Informar Valor da compra:");
           val_pag = float.Parse(Console.ReadLine());
           pf.Pagar_Imposto(val_pag);
           Console.WriteLine("---------- Pessoa Fisica ----------");
           Console.WriteLine("Nome ............: " + pf.nome);
           Console.WriteLine("Endereco.........: " + pf.endereco);
           Console.WriteLine("CPF..............: " + pf.cpf);
           Console.WriteLine("RG...............: " + pf.rg);
           Console.WriteLine("Valor De Compra..: " + pf.valor.ToString("c"));
           Console.WriteLine("Imposto..........: " + pf.valor_imposto.ToString("c"));
           Console.WriteLine("total a pagar....: " + pf.total.ToString("c"));
       }
       if(var_tipo == "j")
       {
           // Pessoa Juridica
           Pessoa_Juridica pj = new Pessoa_Juridica();
           pj.nome = var_nome;
           pj.endereco = var_endereco;
           Console.WriteLine("Informar CNPJ:");
           pj.cnpj = Console.ReadLine();
           Console.WriteLine("Informar IE:");
           pj.ie = Console.ReadLine();
           Console.WriteLine("Informar Valor da compra:");
           val_pag = float.Parse(Console.ReadLine());
           pj.Pagar_Imposto(val_pag);
           Console.WriteLine("---------- Pessoa juridica ----------");
           Console.WriteLine("Nome ............: " + pj.nome);
           Console.WriteLine("Endereco.........: " + pj.endereco);
           Console.WriteLine("CPF..............: " + pj.cnpj);
           Console.WriteLine("RG...............: " + pj.ie);
           Console.WriteLine("Valor De Compra..: " + pj.valor.ToString("c"));
           Console.WriteLine("Imposto..........: " + pj.valor_imposto.ToString("c"));
           Console.WriteLine("total a pagar....: " + pj.total.ToString("c"));
       }
      }
    }
}