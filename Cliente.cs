using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

 public class Cliente{
  private string nomecliente;
  private string emailcliente;
  private int quantvenda;
  private float valorrevenda;

  public float CustoVenda(){
   return valorrevenda*quantvenda;
  }

  public Cliente(){
    nomecliente = "";
    emailcliente = "";
    quantvenda = 0;
    valorrevenda = 0;
  }
  public Cliente(string nome, string email, int qtdvenda, float vrevenda){
    nomecliente = nome;
    emailcliente = email;
    quantvenda = qtdvenda;
    valorrevenda = vrevenda;
  }
  public string getnomecliente(){
    return nomecliente;
  }
  public string getemailcliente(){
    return emailcliente;
  }
  public int getquantvenda(){
    return quantvenda;
  }
  public float getvalorrevenda(){
    return valorrevenda;
  }
  public void setnomeclient (string nome){
    nomecliente = nome;
  }
  public void setemailcliente (string email){
    emailcliente = email;
  }
  public void setquantvenda( int qtdvenda){
    quantvenda = qtdvenda;
  }
  public void setvalorrevenda(float vrevenda){
    valorrevenda = vrevenda;
  }

  public override string  ToString(){
    return "Nome do Cliente "+ nomecliente;
  }
  public string posvenda(){
    return string.Format("Nome do Cliente é: {0} \n O email é: {1} \n A quantidade vendida foi de: {2}\n E o valor de revenda é de:{3}\n E o valor total da venda é de: {4}",nomecliente,emailcliente,quantvenda,valorrevenda,CustoVenda());
  }
  public void ControleDeVendas(Cliente c){
    
    StreamWriter sw = new StreamWriter("vendas.txt", true);

    string str = string.Empty;
    int qtd;
    float val;

    str = c.getnomecliente();
    sw.WriteLine(("nome: ")+str);
    
    str = c.getemailcliente();
    sw.WriteLine(("Email: ")+str);

    qtd = c.getquantvenda();
    sw.WriteLine(("Quantidade: ")+qtd);

    val = c.getvalorrevenda();
    sw.WriteLine(("ValorRevenda: ")+val);

    sw.Close();
  }
}
