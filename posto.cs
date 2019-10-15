using System;
using System.Collections.Generic;
using System.IO;

namespace Fuel{

class posto{
  private List<string> hist_car; 
  private List<double> hist_comb;
  private string marca;

  public posto(){
    hist_car = new List<string>();
    hist_comb = new List<double>();
  }

  public void novo_cliente(double comb, carro c){
    
    if(c.get_status() == true){ //se o carro está ligado, e está
      c.set_status(false); // desligar o carro
    }

    marca = c.abastecer(comb);

    hist_car.Add(marca);
    hist_comb.Add(comb);

    c.set_status(true); //Liga o carro;
  }

  public void get_hist(){ //ler lista e mostar qtd de carros atendidos
  
  StreamWriter hist = File.AppendText("histórico.txt");
    for(int i=0; i<hist_comb.Count; i++){
      hist.WriteLine("Carro: {0} Qtd. de Comb.: {1}", hist_car[i], hist_comb[i]);
    }
  hist.Close();

  StreamReader hist2 = File.OpenText("histórico.txt");
    string linha = "";
    int Linhas = System.IO.File.ReadAllLines("histórico.txt").Length; //LER TODAS AS LINHAS DE ARQ TXT E SABER A QTD DE LINHAS
    for(int i=0; i<Linhas; i++){
      if((linha = hist2.ReadLine()) != null){
        Console.WriteLine(linha);
      }
    }
    hist2.Close();

  hist_car.Clear();
  hist_comb.Clear();
  }

  public static double preco_comb(){
    return 4.5;
  }
}
}