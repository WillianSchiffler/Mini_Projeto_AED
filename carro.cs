using system;

class carro{
  private double qtd_comb;
  private bool status;
  private string marca;

  public carro(double q, bool s, string m){
    qtd_comb = q; // porcentagem
    status = s; //true = ligado e false = desligado
    marca = m; //marca para histórico do posto
  }

  public double get_qtd(){ //retorna a qtd de combustível
  return qtd_comb;
  }

  public void set_liga(){ //liga o carro
  status = true;
  return status;
  }

  public void set_desliga(){ //desliga o carro
  status = false;
  return status;
  }
}