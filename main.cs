using System;
using System.Collections.Generic;
using System.IO;

namespace Fuel{

class MainClass {
  public static void Main () {
    string marca;
    double qtd_comb, valor_total = 0, valor;
    char opcao;
    
    posto meu_posto = new posto();
    
    do{
    Console.WriteLine("Qual seu carro?");
    marca = Console.ReadLine();

    carro meu_carro = new carro(marca);
    
    Console.WriteLine("Quanto de combustível quer abastecer? Em L");
    qtd_comb = double.Parse(Console.ReadLine());

    meu_posto.novo_cliente(qtd_comb, meu_carro);

  valor = qtd_comb*posto.preco_comb();
  Console.WriteLine("Valor: R${0}", valor);
  
  valor_total = valor_total + valor;

  Console.WriteLine("Há um novo cliente? s ou n");
  opcao = char.Parse(Console.ReadLine());
    } while(opcao == 's');

  Console.WriteLine("Deseja ver o histórico do posto? s ou n");
  opcao = char.Parse(Console.ReadLine());
  if(opcao == 's'){
    meu_posto.get_hist();
  }
  
  Console.WriteLine("Faturamento do dia: R${0}", valor_total);

  }
}
}