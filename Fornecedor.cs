using System;
using System.Collections.Generic;

class Fornecedor{
  Estoque  estoque = new Estoque();

  private string empresa;
  private string produto;
  private string codproduto;
  private int quant;
  private float valorproduto;  

  public float CustoCompra(){
    return valorproduto*quant;
  }

  public Fornecedor(){
    empresa = "";
    produto = "";
    codproduto = "";
    quant = 0;
    valorproduto = 0;
  }

  public Fornecedor(string emp, string prod,string cprod, int qtd, float vproduto){
    empresa = emp;
    produto = prod;
    codproduto = cprod;
    quant = qtd;
    valorproduto = vproduto;
  }
  public string getempresa(){
    return empresa;
  }
  public string getproduto(){
    return produto;
  }
  public string getcodproduto(){
    return codproduto;
  }
  public int getquant(){
    return quant;
  }
  public float getvalorproduto(){
    return valorproduto;
  }

  public void setempresa(string emp){
    empresa = emp;
  }
  public void setproduto(string prod){
    produto = prod;
  }
  public void setcodproduto(string cprod){
    codproduto = cprod;
  }
  public void setquant(int qtd){
    quant = qtd;
  }
  public void setvalorproduto(float vproduto){
    valorproduto = vproduto;
  }

  public Fornecedor  ComprarProduto(string empresa, string produto,string codproduto, int quant , float valorproduto){
    // dentro do parâmetro eu coloquei os atributos que vão receber as informações 
     

    // aqui estou criando um novo produto com os as informações que o usuario passar 
    Fornecedor fornecedor= new Fornecedor(empresa,produto,codproduto,quant,valorproduto);
    // estou retorna  ndo o produto  
    estoque.IncluirFornecedor(fornecedor);
    return fornecedor;
       
  }

   public void AssociarEstoque(Estoque est){
    estoque=est;
  }
  

  public string ResumoCompra(){
    return string.Format("Nome da Empresa é: {0} \n O produto adquirido foi: {1} \n O Código do produto é:{2} \n 1A quantidade foi de: {3}\n E o valor total da compra é de:{4}",empresa,produto,codproduto,quant,valorproduto,CustoCompra());
  }
  public string MostrarNaLista(){
    return string.Format("Nome da Empresa é: {0} \n O produto adquirido foi: {1} \n O Código do produto é:{2} \n A quantidade foi de: {3}\n E o valor do produto é de:{4} \n E o valor total da compra é de:{5} \n ============================ \n",empresa,produto,codproduto,quant,valorproduto,CustoCompra());
  }
}