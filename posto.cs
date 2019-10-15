using System;
using System.Collections.Generic;
using System.IO;

namespace Fuel{

class posto{
  private double qtd_carros;
  private List<string> hist_car; 
  private List<double> hist_comb;
  private double g;

  public posto(){
    hist_car = new List<string>();
    hist_comb = new List<double>();
  }

  public void abastecer(double q, carro u){ //carro sendo abastecido; "c" é a condição do carro ligado ou delsigado;
  
  if(u.status == false){
  u.qtd_comb = u.qtd_comb + q;
    
    /*StreamWriter hist = File.AppendText("histórico.txt");
    for(int i=0; i<hist_comb.Count; i++){
      hist.WriteLine("Carro: {0} Qtd. de Comb.: {1}", hist_car[i], hist_comb[i]);
    }
    hist.Close();
    */
    }
  
  else{
    Console.WriteLine("Desligue o carro, primeiro!");
  }
  }

  public void get_hist(){ //ler lista e mostar qtd de carros atendidos
  StreamReader hist2 = File.OpenText("histórico.txt");
    for(int i=0; i<=hist_car.Count; i++){
      if(hist2.ReadLine() != null){
        Console.WriteLine(hist2.ReadLine());
      }
    }
  }

  public static double preco_comb(){
    return 4.5;
  }
}
}