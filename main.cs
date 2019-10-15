using System;
using System.Collections.Generic;
using System.IO;

namespace Fuel{

class MainClass {
  public static void Main () {
    string marca;
    double combs, qtd_comb, valor_total;
    char opcao;
    
    Console.WriteLine("Qual seu carro?");
    marca = Console.ReadLine();
    Console.WriteLine("Quanto de combustível possui? Em %");
    combs = double.Parse(Console.ReadLine());

    carro meu_carro = new carro(marca, combs);
    posto ipiranga = new posto();

  do{
    Console.WriteLine("Quant. atual de comb.: {0}%", meu_carro.get_qtd_comb());
    
    Console.WriteLine("Quanto de combustível quer abastecer? Em %");
    qtd_comb = double.Parse(Console.ReadLine());
    
    if(meu_carro.get_status() == true){
      meu_carro.set_status(false); //desligar carro
    }

    ipiranga.abastecer(qtd_comb, meu_carro);
    
    if((meu_carro.get_qtd_comb()) < 100){
      Console.WriteLine("Deseja continuar abastecendo? s ou n");
      opcao = char.Parse(Console.ReadLine());
    }
      else{
        opcao = 'n';
      }
  } while (opcao == 's');

  valor_total = qtd_comb*posto.preco_comb();
  Console.WriteLine("Valor total: R${0}", valor_total);

  Console.WriteLine("Deseja ver o histórico do posto? s ou n");
  if(char.Parse(Console.ReadLine()) == 's'){
    ipiranga.get_hist();
  }

  }
}
}