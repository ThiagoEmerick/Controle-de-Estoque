using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Fornecedor{
  Estoque  estoque = new Estoque();


  private string produto;
  private string codproduto;
  private int quant;
  private float valorproduto;  

  public float CustoCompra(){
    return valorproduto*quant;
  }

  public Fornecedor(){

    produto = "";
    codproduto = "";
    quant = 0;
    valorproduto = 0;
  }

  public Fornecedor(string prod,string cprod, int qtd, float vproduto){
 
    produto = prod;
    codproduto = cprod;
    quant = qtd;
    valorproduto = vproduto;
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

  public Fornecedor  ComprarProduto( string produto,string codproduto, int quant , float valorproduto){
   
    Fornecedor fornecedor= new Fornecedor(produto,codproduto,quant,valorproduto); 
    estoque.IncluirFornecedor(fornecedor);
    return fornecedor;
       
  }

   public void AssociarEstoque(Estoque est){
    estoque=est;
  }

  public bool verificarCodigo(List <Fornecedor> p , string cod){
    List <string> codigos = new List <string> ();
    foreach(Fornecedor vc in p){
      codigos.Add(vc.getcodproduto());
    }
    if (codigos.IndexOf(cod)!= -1){
      return false;
    }
    return true;
  }
  

  public string ResumoCompra(){
    return string.Format("\n O produto adquirido foi: {0} \n O Código do produto é:{1} \n 1A quantidade foi de: {2}\n E o valor total da compra é de:{3}",produto,codproduto,quant,valorproduto,CustoCompra());
  }
  public string MostrarNaLista(){
    return string.Format("\n O produto adquirido foi: {0} \n O Código do produto é:{1} \n A quantidade foi de: {2}\n E o valor do produto é de:{3} \n E o valor total da compra é de:{4} \n ============================ \n",produto,codproduto,quant,valorproduto,CustoCompra());
  }

  public void ControleDeCompras(string e, string p, string c, int q, float v){

    StreamWriter sw = new StreamWriter("compras.txt", true);

    string str = string.Empty;
    int iq;
    float fv;

    str = e;
    sw.WriteLine(("Empresa: ")+str);
    str = p;
    sw.WriteLine(("Produto: ")+str);
    str = c;
    sw.WriteLine(("Codigo do Produto: ")+str);
    iq = q;
    sw.WriteLine(("Quantidade: ")+iq);
    fv = v;
    sw.WriteLine(("Valor do Produto: ")+fv);

    sw.Close();

  }

}