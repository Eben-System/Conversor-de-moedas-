using System;
class Conversor2{
	static void Main(){
		Console.WriteLine("===Conversor de Moedas===");
		Console.WriteLine("         ");
		Console.WriteLine("--Escolha uma moeda--");
		Console.WriteLine("1-> USD - Dólar Americano:");
		Console.WriteLine("2-> EUR - Euro:");
		Console.WriteLine("3-> GBP - Libra Estrelina:");
		Console.WriteLine("4-> JPY - lene Japonês:");
		Console.WriteLine("5-> CNY - Yuan Chinês:");
		Console.WriteLine("6-> Kz - Kuanza Angolano:");
		
		int opcao = int.Parse(Console.ReadLine());
		
		//taxa do kuanza para outras moedas//
		double taxaUSDKz=916.53; 
		double taxaEURKz=1.073;
		double taxaGBPKz=1.237;
		double taxaJPYKz=5.80;
		double taxaCNYKz=136.64;
		
		//taxa do dólar para outras moedas//
		double taxaKzUSD=916.53;
		double taxaEURUSD=0.876;
		double taxaGBPUSD=0.752;
		double taxaJPYUSD=157.50;
		double taxaCNYUSD=6.70;
		
		//taxa do euro para outras moedas//
		double taxaKzEUR=1073.18;
		double taxaUSDEUR=1.144;
		double taxaGBPEUR=0.858;
		double taxaJPYEUR=186.38;
		double taxaCNYEUR=7.66;
		
		//taxa da libra estrelina//
		double taxaKzGBP=1237.49;
		double taxaUSDGBP=1.333;
		double taxaEURGBP=1.165;
		double taxaJPYGBP=216.32;
		double taxaCNYGBP=8.95;
		
		//taxa do lene japonês para outras moedas//
		double taxaKzJPY=5.80;
		double taxaUSDJPY=0.00634;
		double taxaEURJPY=0.00536;
		double taxaGBPJPY=0.00462;
		double taxaCNYJPY=0.0413;
		
		//taxa do yuan chinês para outras moedas//
		double taxaKzCNY=136.64;
		double taxaUSDCNY=0.149;
		double taxaEURCNY=0.130;
		double taxaGBPCNY=0.111;
		double taxaJPYCNY=24.16;
		
		//processamento do conversor//
		//Dolar//
		if(opcao==1){
			Console.WriteLine("----Seleccione a outra moeda para converter do Dólar:-----");
			Console.WriteLine("1-EURO(EUR)");
			Console.WriteLine("2-Kuanza(KZ)");
			Console.WriteLine("3-Libra EStrelina(GBP)");
			Console.WriteLine("4-Lene Japonês(JPY)");
			Console.WriteLine("5-Yuan Chinês(CNY)");
			Console.Write("R:  ");
			
			int opcao1 = int.Parse(Console.ReadLine());
			
			
			if(opcao1==1){
				Console.Write("Digite o valor em Dólar: ");
				double a1 = double.Parse(Console.ReadLine());
				
				double a01 = a1 / taxaEURUSD;
				Console.WriteLine($"{a1}USD = {a01}EUR");
				
			}else if(opcao1==2){
				Console.Write("Digite o valor em Dólar: ");
				double a2 = double.Parse(Console.ReadLine());
				
				double a02 = a2 / taxaKzUSD;
				Console.WriteLine($"{a2}USD = {a02}Kz ");
			}else if(opcao1==3){
				Console.Write("Digite o valor em Dólar: ");
				double a3 = double.Parse(Console.ReadLine());
				
				double a03 = a3 / taxaGBPUSD;
				Console.WriteLine($"{a3}USD = {a03}GBP ");
			}else if(opcao1==4){
				Console.Write("Digite o valor em Dólar: ");
				double a4 = double.Parse(Console.ReadLine());
				
				double a04 = a4 / taxaJPYUSD;
				Console.WriteLine($"{a4}USD = {a04}JPY");
			}else if(opcao1==5){
				Console.Write("Digite o valor em Dólar: ");
				double a5 = double.Parse(Console.ReadLine());
				
				double a05 = a5 / taxaCNYUSD;
				Console.WriteLine($"{a5}USD = {a05}CNY");
			}
				 
		} else if(opcao==2){
			Console.WriteLine("----Seleccione a outra moeda para converter do Euro:-----");
			Console.WriteLine("1-Dólar Americano(USD)");
			Console.WriteLine("2-Kuanza(KZ)");
			Console.WriteLine("3-Libra EStrelina(GBP)");
			Console.WriteLine("4-Lene Japonês(JPY)");
			Console.WriteLine("5-Yuan Chinês(CNY)");
			Console.Write("R:  ");
			
			int opcao2 = int.Parse(Console.ReadLine());
			
			
			if(opcao2==1){
				Console.Write("Digite o valor em Euro: ");
				double b1 = double.Parse(Console.ReadLine());
				
				double b01 = b1 / taxaUSDEUR;
				Console.WriteLine($"{b1}EUR = {b01}USD");
				
			}else if(opcao2==2){
				Console.Write("Digite o valor em Euro: ");
				double b2 = double.Parse(Console.ReadLine());
				
				double b02 = b2 / taxaKzEUR;
				Console.WriteLine($"{b2}EUR = {b02}Kz ");
			}else if(opcao2==3){
				Console.Write("Digite o valor em EURO: ");
				double b3 = double.Parse(Console.ReadLine());
				
				double b03 = b3 / taxaGBPEUR;
				Console.WriteLine($"{b3}EUR = {b03}GBP ");
			}else if(opcao2==4){
				Console.Write("Digite o valor em Euro: ");
				double b4 = double.Parse(Console.ReadLine());
				
				double b04 = b4 / taxaJPYEUR;
				Console.WriteLine($"{b4}EUR = {b04}JPY");
			}else if(opcao2==5){
				Console.Write("Digite o valor em Euro: ");
				double b5 = double.Parse(Console.ReadLine());
				
				double b05 = b5 / taxaCNYEUR;
				Console.WriteLine($"{b5}EUR = {b05}CNY");
			}
				 
		} else if(opcao==3){
			Console.WriteLine("----Seleccione a outra moeda para converter da Libra Estrelina:-----");
			Console.WriteLine("1-EURO(EUR)");
			Console.WriteLine("2-Kuanza(KZ)");
			Console.WriteLine("3-Dólar Americano(USD)");
			Console.WriteLine("4-Lene Japonês(JPY)");
			Console.WriteLine("5-Yuan Chinês(CNY)");
			Console.Write("R:  ");
			
			int opcao3 = int.Parse(Console.ReadLine());
			
			
			if(opcao3==1){
				Console.Write("Digite o valor em Libra Estrelina: ");
				double c1 = double.Parse(Console.ReadLine());
				
				double c01 = c1 / taxaEURGBP;
				Console.WriteLine($"{c1}GBP = {c01}EUR");
				
			}else if(opcao3==2){
				Console.Write("Digite o valor em Libra Estrelina: ");
				double c2 = double.Parse(Console.ReadLine());
				
				double c02 = c2 / taxaKzGBP;
				Console.WriteLine($"{c2}GBP = {c02}Kz ");
			}else if(opcao3==3){
				Console.Write("Digite o valor em Libra Estrelina: ");
				double c3 = double.Parse(Console.ReadLine());
				
				double c03 = c3 / taxaUSDGBP;
				Console.WriteLine($"{c3}GBP = {c03}USD ");
			}else if(opcao3==4){
				Console.Write("Digite o valor em Libra Estrelina: ");
				double c4 = double.Parse(Console.ReadLine());
				
				double c04 = c4 / taxaJPYGBP;
				Console.WriteLine($"{c4}GBP = {c04}JPY");
			}else if(opcao3==5){
				Console.Write("Digite o valor em Libra Estrelina: ");
				double c5 = double.Parse(Console.ReadLine());
				
				double c05 = c5 / taxaCNYGBP;
				Console.WriteLine($"{c5}GBP = {c05}CNY");
			}
				 
		} else if(opcao==4){
			Console.WriteLine("----Seleccione a outra moeda para converter do Lene Japonês:-----");
			Console.WriteLine("1-EURO(EUR)");
			Console.WriteLine("2-Kuanza(KZ)");
			Console.WriteLine("3-Libra EStrelina(GBP)");
			Console.WriteLine("4-Dólar Americano(USD)");
			Console.WriteLine("5-Yuan Chinês(CNY)");
			Console.Write("R:  ");
			
			int opcao4 = int.Parse(Console.ReadLine());
			
			
			if(opcao4==1){
				Console.Write("Digite o valor em Lene Japonês: ");
				double d1 = double.Parse(Console.ReadLine());
				
				double d01 = d1 / taxaEURJPY;
				Console.WriteLine($"{d1}JPY = {d01}EUR");
				
			}else if(opcao4==2){
				Console.Write("Digite o valor em Lene Japonês: ");
				double d2 = double.Parse(Console.ReadLine());
				
				double d02 = d2 / taxaKzJPY;
				Console.WriteLine($"{d2}JPY = {d02}Kz ");
			}else if(opcao4==3){
				Console.Write("Digite o valor em Lene Japonês: ");
				double d3 = double.Parse(Console.ReadLine());
				
				double d03 = d3 / taxaGBPJPY;
				Console.WriteLine($"{d3}JPY = {d03}GBP ");
			}else if(opcao4==4){
				Console.Write("Digite o valor em Lene Japonês: ");
				double d4 = double.Parse(Console.ReadLine());
				
				double d04 = d4 / taxaUSDJPY;
				Console.WriteLine($"{d4}JPY = {d04}USD");
			}else if(opcao4==5){
				Console.Write("Digite o valor em Lene Japonês: ");
				double d5 = double.Parse(Console.ReadLine());
				
				double d05 = d5 / taxaCNYJPY;
				Console.WriteLine($"{d5}JPY = {d05}CNY");
			}
				 
		} else if(opcao==1){
			Console.WriteLine("----Seleccione a outra moeda para converter do Yuan Chinês:-----");
			Console.WriteLine("1-EURO(EUR)");
			Console.WriteLine("2-Kuanza(KZ)");
			Console.WriteLine("3-Libra EStrelina(GBP)");
			Console.WriteLine("4-Lene Japonês(JPY)");
			Console.WriteLine("5-Dólar Americano(USD)");
			Console.Write("R:  ");
			
			int opcao5 = int.Parse(Console.ReadLine());
			
			
			if(opcao5==1){
				Console.Write("Digite o valor em Yuan chinês: ");
				double e1 = double.Parse(Console.ReadLine());
				
				double e01 = e1 / taxaEURCNY;
				Console.WriteLine($"{e1}CNY= {e01}EUR");
				
			}else if(opcao5==2){
				Console.Write("Digite o valor em Yuan Chinês: ");
				double e2 = double.Parse(Console.ReadLine());
				
				double e02 = e2 / taxaKzCNY;
				Console.WriteLine($"{e2}CNY = {e02}Kz ");
			}else if(opcao5==3){
				Console.Write("Digite o valor em Yuan Chinês: ");
				double e3 = double.Parse(Console.ReadLine());
				
				double e03 = e3 / taxaGBPCNY;
				Console.WriteLine($"{e3}CNY = {e03}GBP ");
			}else if(opcao5==4){
				Console.Write("Digite o valor em Yuan Chinês: ");
				double e4 = double.Parse(Console.ReadLine());
				
				double e04 = e4 / taxaJPYCNY;
				Console.WriteLine($"{e4}CNY = {e04}JPY");
			}else if(opcao5==5){
				Console.Write("Digite o valor em Yuan Chinês: ");
				double e5 = double.Parse(Console.ReadLine());
				
				double e05 = e5 / taxaUSDCNY;
				Console.WriteLine($"{e5}CNY = {e05}USD");
			}
				 
		}else if(opcao==6){
			Console.WriteLine("----Seleccione a outra moeda para converter do Kuanza:-----");
			Console.WriteLine("1-EURO(EUR)");
			Console.WriteLine("2-Dólar Americano(USD)");
			Console.WriteLine("3-Libra EStrelina(GBP)");
			Console.WriteLine("4-Lene Japonês(JPY)");
			Console.WriteLine("5-Yuan Chinês(CNY)");
			Console.Write("R:  ");
			
			int opcao6 = int.Parse(Console.ReadLine());
			
			
			if(opcao6==1){
				Console.Write("Digite o valor em Kuanza: ");
				double f1 = double.Parse(Console.ReadLine());
				
				double f01 = f1 / taxaEURKz;
				Console.WriteLine($"{f1}Kz = {f01}EUR");
				
			}else if(opcao6==2){
				Console.Write("Digite o valor em Kuanza: ");
				double f2 = double.Parse(Console.ReadLine());
				
				double f02 = f2 / taxaUSDKz;
				Console.WriteLine($"{f2}Kz = {f02}USD ");
			}else if(opcao6==3){
				Console.Write("Digite o valor em Kuanza: ");
				double f3 = double.Parse(Console.ReadLine());
				
				double f03 = f3 / taxaGBPKz;
				Console.WriteLine($"{f3}Kz = {f03}GBP ");
			}else if(opcao6==4){
				Console.Write("Digite o valor em Kuanza: ");
				double f4 = double.Parse(Console.ReadLine());
				
				double f04 = f4 / taxaJPYKz;
				Console.WriteLine($"{f4}Kz = {f04}JPY");
			}else if(opcao6==5){
				Console.Write("Digite o valor em Kuanza: ");
				double f5 = double.Parse(Console.ReadLine());
				
				double f05 = f5 / taxaCNYKz;
				Console.WriteLine($"{f5}Kz = {f05}CNY");
			}
				 
		} else {
			Console.WriteLine("Opção inválida");
		}
		}
		}
			
		//Eben System//
		//Robson Magalhães//
		//Dev C#//
		 //24 de Setembro de 2026// 
			
		
		
			
	

	

