using System;
using System.Collections.Generic;

class MainClass {

  public static void Main (string[] args) {

    Fornecedor  fornecedor = new Fornecedor();

    Estoque estoque = new Estoque();
    fornecedor.AssociarEstoque(estoque);

    bool repeticao = true;

    while (repeticao == true){
    
    Console.WriteLine ("Digite 1 para comprarmos um produto: /n 2 para vendermos um produto em estoque: ");
    int opcao = Int32.Parse(Console.ReadLine());
    

    switch(opcao){
      
      case 1:
        Console.WriteLine("Empresa Fornecedora:");
        string empresa = Console.ReadLine();
        
        Console.WriteLine("Qual produto esta sendo adquirido:");
        string produto = Console.ReadLine();

        Console.WriteLine("Entre com o código do produto:");
        string codproduto = Console.ReadLine();
       
        Console.WriteLine("Quantidade sendo adquirida:");
        int quantidade = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Valor de cada produto:");
        float valorproduto = float.Parse(Console.ReadLine());

        Fornecedor listaforne = fornecedor.ComprarProduto(empresa,produto,codproduto,quantidade,valorproduto);

        estoque.MostrarFornecedor();
        break;
      
      case 2:
        
        estoque.MostrarFornecedor();
        
        Console.WriteLine("digite o codigo:");
        string dadosCodigo = Console.ReadLine();
        estoque.BuscarEstoque(dadosCodigo);
        
        Console.WriteLine("Nome do Cliente:");
        string nomecliente = Console.ReadLine();
        
        Console.WriteLine("E-mail do Cliente:");
        string emailcliente = Console.ReadLine();
        
        Console.WriteLine("Quantidade que irá comprar:");
        int quantcompra =int.Parse (Console.ReadLine());

        Console.WriteLine("Valor de revenda:");
        float valorrevenda = float.Parse (Console.ReadLine());

        break;
       
       default:
        break;
    }

      Console.WriteLine("Deseja fazer outro pedido? (S/N):");
       string rep = Console.ReadLine();
       if (rep == "N" || rep =="n"){
         repeticao = false;
       }
    }
  }
}