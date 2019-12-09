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

  public  bool  MaiorqueZERO(int quantvenda){
      foreach (Fornecedor p in forne){
      if (quantvenda < p.getquant()){
        return true;
        }
      }
      return false;
  }
  public void retirar(string bc, int quantvenda){
    foreach (Fornecedor p in forne){
      
      if (bc == p.getcodproduto()){
        if (MaiorqueZERO(quantvenda)){
          p.setquant(p.getquant()- quantvenda);
          Console.WriteLine(ToString());
        }else{
          Console.WriteLine("Quantidade invalida");
        } 
      }
     }
  }
}


   


