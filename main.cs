using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class MainClass {

  public static void Main (string[] args) {

    Fornecedor  fornecedor = new Fornecedor();

    Estoque estoque = new Estoque();
    fornecedor.AssociarEstoque(estoque);

    bool repeticao = true;

    while (repeticao == true){
    
    Console.WriteLine ("Digite: \n 1 para comprarmos um produto. \n 2 Para vendermos um produto em estoque. \n 3 Para ver o estoque. \n 4 Para excluir os arquivos");
    int opcao = Int32.Parse(Console.ReadLine());
    

    switch(opcao){
      
      case 1:

        
        Console.WriteLine("Entre com o código do produto:");
        string codproduto = Console.ReadLine();
        
        if(fornecedor.verificarCodigo(estoque.forne , codproduto)){
        Console.WriteLine("Empresa Fornecedora:");
        string empresa = Console.ReadLine();
        
        Console.WriteLine("Qual produto esta sendo adquirido:");
        string produto = Console.ReadLine();
       
        Console.WriteLine("Quantidade sendo adquirida:");
        int quantidade = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Valor de cada produto:");
        float valorproduto = float.Parse(Console.ReadLine());

        Fornecedor listaforne = fornecedor.ComprarProduto(produto,codproduto,quantidade,valorproduto);

        fornecedor.ControleDeCompras(empresa,produto,codproduto,quantidade,valorproduto);

        estoque.MostrarFornecedor();
      }else{
        Console.WriteLine("Já Existe esse Código:");
      }
      break;

      case 2:
        Console.WriteLine("digite a opcao 1 para empresa e 2 para autonomo :");
        string opcao1 = Console.ReadLine();
      if (opcao1 == "1" ){
        
        estoque.MostrarFornecedor();
        
        Console.WriteLine("digite o codigo:");
        string dadosCodigo = Console.ReadLine();
        estoque.BuscarEstoque(dadosCodigo);
        
        Console.WriteLine("Nome do Cliente:");
        string nomecliente = Console.ReadLine();
        
        Console.WriteLine("E-mail do Cliente:");
        string emailcliente = Console.ReadLine();

        Console.WriteLine("Valor de revenda:");
        float valorrevenda = float.Parse (Console.ReadLine());
        
        Console.WriteLine("Quantidade que irá comprar:");
        int quantvenda =int.Parse (Console.ReadLine());

        Console.WriteLine("Digite seu cnpj:");
        string cnpj = Console.ReadLine();

        Empresa novocliente = new Empresa(nomecliente,emailcliente,quantvenda,valorrevenda,cnpj);
        
        estoque.retirar(dadosCodigo,quantvenda);
     

        novocliente.ControleDeVendas(novocliente);

        novocliente.posvenda();




      }
         
        
       

        break;

      case 3:
       estoque.MostrarFornecedor();
        
        break;
      
      case 4:

      File.Delete("compras.txt");
      File.Delete("vendas.txt");
      
      break;
       
      default:
        break;
      }
    }
  }
}
