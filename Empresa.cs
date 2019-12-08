using System;

class Empresa : Cliente{

  public string cnpj{get;set;}

  public Empresa(){
    cnpj = "";
  }
  public Empresa(string cnpj){
    this.cnpj = cnpj;
  }
   public  Empresa(string nc ,string e , int qtdv,float vlr ,string cnpj): base(nc,e,qtdv,vlr ){

    cnpj = cnpj;
  }
}