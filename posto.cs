using system;

class posto{
  private double preco_comb;
  private double qtd_carros;
  private List<string> carros;
  // carro c;

  public posto(){
    preco_comb = 10; //preço do combustível
    qtd_carros = 0; //posto acabou de abrir
  }

  public void abastecer(double q){ //carro sendo abastecido
  carro.qtd_comb = carro.qtd_comb + q;
  }

  public void get_hist_car(){ //ler lista e mostar qtd de carros atendidos

  }

  public void set_preco_comb(double v){
    preco_comb = v;
  }
}