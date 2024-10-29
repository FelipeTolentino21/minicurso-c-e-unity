// **** Organizar os exercícios com base no slide ****

using System;

public class main{
    static void Main(){
    // Solicite ao usuário uma string e substitua todas as ocorrências de uma letra por outra informada pelo usuário.
    /*
    Console.Write("Insira uma frase: ");
    string frase = Console.ReadLine();
    frase = frase.ToLower();
    Console.Write("Insira uma letra para ser substituida: ");
    string letraAnterior = Console.ReadLine();
    Console.Write("Insira a letra que você quer substituir: ");
    string letraParaSubstituir = Console.ReadLine();
    
    Console.Write($"Aqui esta sua nova frase: " + frase.Replace(letraAnterior, letraParaSubstituir));
    */
    // Fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.
    /*
    double soma = 0;
    
    Console.Write("Insira o numero de pessoas que quer fazer a média da altura: ");
    int n = int.Parse(Console.ReadLine());
    double []alturas = new double[n];
    
    for(int i=0;i<n;i++){
        Console.Write($"Altura da {i+1}ª pessoa: ");
        alturas[i]  = double.Parse(Console.ReadLine());
        soma += alturas[i];
    }
    double media = soma/n;
    Console.Write($"A média das alturas ficou: {Convert.ToDecimal(media).ToString("0.00")}");
    */
    /*
    Faça um algoritmo que preencha uma matriz 3x3 de inteiros e escreva: 
    a) a soma dos números ímpares fornecidos; 
    b) a soma de cada uma das 3 colunas; 
    c) a soma de cada uma das 3 linhas. 
    */
    /*
    int somaImpar = 0;
    
    int [ , ]matriz = new int[3,3];
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            Console.Write($"Insira o valor que quer colocar em [{i}][{j}]: ");
            matriz[i,j] = int.Parse(Console.ReadLine());
            if(matriz[i,j]%2!=0){
                somaImpar += matriz[i,j];
            }
        }
    }
    for(int i=0;i<3;i++){
        Console.Write("\n");
        for(int j=0;j<3;j++){
            Console.Write($"[{i}][{j}]: {matriz[i,j]}\t");
        }
    }
    
    int []somaLinha = new int[3];
    int []somaColuna = new int[3];
    
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            somaLinha[i] += matriz[i,j];
            somaColuna[j] += matriz[i,j];
        }
    }
    
    Console.WriteLine($"\n\na) A soma dos valores impares fornecidos é: {somaImpar}");
    Console.WriteLine("\nb) A soma das colunas é:");
    for(int j=0;j<3;j++){
        Console.WriteLine($" Coluna[{j}]: {somaColuna[j]}");
    }
    Console.WriteLine("\nc) A soma das linhas é:");
    for(int i=0;i<3;i++){
        Console.Write($"Linha [{i}]: {somaLinha[i]}\t");
    }
    */
  }
}
