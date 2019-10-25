using System.Collections.Generic;
using System;


class Estoque{

  public List<Fornecedor> forne = new List<Fornecedor>();

  public void IncluirFornecedor(Fornecedor fornecedor){
    forne.Add(fornecedor);
    
  }
  public void MostrarFornecedor(){
    for(int i = 0 ; i < forne.Count ; i++){
      Console.WriteLine(forne[i].MostrarNaLista());
    }
  }
  public void BuscarEstoque( string bc){
    foreach (Fornecedor p in forne){
      if (bc == p.getcodproduto()){
        Console.WriteLine(p.MostrarNaLista());     
      }
    }
  }
  public void retirar(string bc, int quantvenda){
    foreach (Fornecedor p in forne){
      if (bc == p.getcodproduto()){
        p.setquant(p.getquant()- quantvenda);
    }
  }
 }
} 
   


