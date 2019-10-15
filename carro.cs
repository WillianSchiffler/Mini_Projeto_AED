using System;
using System.Collections.Generic;
using System.IO;

namespace Fuel{

class carro{
  public double qtd_comb;
  private string marca;
  public bool status;

  public carro(string m, double q){
  qtd_comb = q;
  marca = m; //marca para histórico do posto
  status = true;
  }

  public double get_qtd_comb(){ //retorna a qtd de combustível
  return qtd_comb;
  }

  public void set_status(bool s){ //liga ou desliga o carro
  status = s;
  }

}
}