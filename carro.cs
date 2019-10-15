using System;
using System.Collections.Generic;
using System.IO;

namespace Fuel{
  class carro{
  private double qtd_comb;
  private string marca;
  private bool status;
  
  public carro(string m){
  marca = m; //marca para histórico do posto
  status = true;
  }

  public string abastecer(double q){ //carro sendo abastecido
  qtd_comb = qtd_comb + q;
  return marca;
  }

  public void set_status(bool s){ // Liga ou desliga o carro
  status = s;
  }

  public bool get_status(){ // O carro está ligado ou desligado?
  return status;
  }
  }
}