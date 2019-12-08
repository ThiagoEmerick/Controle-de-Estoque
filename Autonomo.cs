using System;

public class Autonomo : Cliente{

  public string cep{get;set;}

  public Autonomo(){
    cep = "";
  }
  public Autonomo(string cep){
    this.cep = cep;
  }

  public  Autonomo(string nc ,string e , int qtdv,float vlr ,string c): base(nc,e,qtdv,vlr ){

    cep =c;

   
  }

}