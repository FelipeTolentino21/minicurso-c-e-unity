// **** Organizar os exercícios com base no slide ****

using System;

public class main{
    //função do exercício 1
    /*public static int produto (int x, int y){
      return x*y;
}*/ //Função do exercício 2
    /*
    public static void verifica (int x){
    if (x % 2 == 0){
        Console.WriteLine($"{x} é múltiplo de 2");
    } else {
        Console.WriteLine($"{x} não é múltiplo de 2");
    }
}   */ //Função do exercício 3
   /* public static double CalcularMedia(double[] numeros){   
        if (numeros.Length == 0) {
            throw new ArgumentException("O array de números não pode ser vazio.");
        }

        double soma = 0;
        for (int i = 0; i < numeros.Length; i++) {
            soma += numeros[i];
        }

        double media = soma / numeros.Length;
        return media;
    }*/ /*//Função do exercício 4
        public static double CalcularMedia(double nota1, double nota2, double nota3, char tipoMedia) {
        double media;

        if (tipoMedia == 'A' || tipoMedia == 'a') {
            // Média aritmética
            media = (nota1 + nota2 + nota3) / 3;
        }
        else if (tipoMedia == 'P' || tipoMedia == 'p') {
            // Média ponderada com pesos 5, 3 e 2
            media = ((nota1 * 5) + (nota2 * 3) + (nota3 * 2)) / 10;
        } else
        {
            throw new ArgumentException("Tipo de média inválido. Use 'A' para aritmética ou 'P' para ponderada.");
        }

        return media;
    }*/ //função do exercício 6
        public static string RemoverVogais(string texto) {
        string resultado = "";
        foreach (char c in texto) {
            if (!"AEIOUaeiouÁÉÍÓÚáéíóú".Contains(c)) {
                resultado += c;
            }
        }
        return resultado;
    }
        
    static void Main(){
        //Função do exercício 7
            
    // Exercício 1: Faça uma função que aceita 2 inteiros e retorna a multiplicação. 
       /* int a, b;
        Console.WriteLine("Digite um número");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número");
        b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("O produto desses números é: " + produto(a,b));
        */
    // Exercício 2: Faça uma função que receba um inteiro e mostre na tela se ele for múltiplo de 2.
        /*int a;
        Console.WriteLine("Digite um número");
        a = int.Parse(Console.ReadLine());
        
        verifica(a); */
    // Exercício 3: Faça uma função que calcule a média aritmética de N números.
       /* double[] numeros = {5, 10, 15, 20, 25}; //números usados apenas como exemplo
        double media = CalcularMedia(numeros);

        Console.WriteLine($"A média aritmética é: {media}"); */
    // Exercício 4: Elabore uma função que receba três notas de um aluno como parâmetro e uma letra. Se a letra for ‘A’ / ‘a’, a função deve calcular a média aritmética das notas do aluno; se a letra for ‘P’ / ‘p’, deverá calcular a média ponderada, com pesos 5, 3 e 2, respectivamente com as notas 1, 2, 3. Retorne a média calculada para o programa principal.    
        /*Console.WriteLine("Digite a primeira nota:");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota:");
        double nota3 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o tipo de média (A para aritmética ou P para ponderada):");
        char tipoMedia = char.Parse(Console.ReadLine());

        try
        {
            double media = CalcularMedia(nota1, nota2, nota3, tipoMedia);
            Console.WriteLine($"A média calculada é: {media}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    } */
    
    // Exercício 5: solicite ao usuário uma string e substitua todas as ocorrências de uma letra por outra informada pelo usuário.
    /*
    Console.Write("Insira uma frase: ");
    string frase = Console.ReadLine();
    frase = frase.ToLower();
    Console.Write("Insira uma letra para ser substituida: ");
    string letraAnterior = Console.ReadLine();
    Console.Write("Insira a letra que você quer substituir: ");
    string letraParaSubstituir = Console.ReadLine();
    
    Console.Write($"Aqui esta sua nova frase: " + frase.Replace(letraAnterior, letraParaSubstituir));
    */ //Exercício 6: Escreva um programa que receba uma string e remova todas as vogais. Informe ao usuário o resultado.
        Console.WriteLine("Digite uma frase:");
        string texto = Console.ReadLine();

        string resultado = RemoverVogais(texto);

        Console.WriteLine($"Sua frase sem vogais: {resultado}");
        
    //Exercício 7 fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.
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
    */ //Exercício 8: Faça um programa que leia um número inteiro positivo N (máximo = 10) e depois N números inteiros e armazene-os em um vetor. Em seguida, mostrar na tela todos os números negativos lidos. 
        
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
