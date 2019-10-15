using System;
using System.Collections.Generic;
using System.IO;

namespace Fuel{

class carro{
  private double qtd_comb;
  private string marca;
  private bool status;

  public carro(string m, double q){
  qtd_comb = q;
  marca = m; //marca para histórico do posto
  status = true;
  }

  public double get_qtd_comb(){ //retorna a qtd de combustível
  return qtd_comb;
  }

  public void set_qtd_comb(double g){
  qtd_comb = qtd_comb + g;
  }

  public void set_status(bool s){ //liga ou desliga o carro
  status = s;
  }

  public bool get_status(){ //liga ou desliga o carro
  return status;
  }

  public string get_marca(){
    return marca;
  }

}
}