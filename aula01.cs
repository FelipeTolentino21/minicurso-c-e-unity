using System;

public class main{
    static void Main(){
        /* Exemplos de print
        double x = 10.35784;
        
        Console.WriteLine("Resultado = " + x + " Metros");
        Console.WriteLine($"Resultado = {x} metros");
        Console.WriteLine($"Resultado = {Convert.ToDecimal(x).ToString("0.000")} metros");
        // Utilizado para reduzir a quantidade de casas decimais
        */
        
        /* Exercício 1: Inicialize as seguintes variáveis e dê os seguintes prints
        string product1 = "Computer";
        string product2 = "Office desk";
        
        int age = 30;
        int code = 5290;
        string gender = "F";
        
        double price1 = 2100.0;
        double price2 = 650.50;
        double measure = 53.234567;
        
        Console.WriteLine("Products:");
        Console.WriteLine($"{product1}, witch the price is ${Convert.ToDecimal(price1).ToString("0.00")}");
        Console.WriteLine($"{product2}, witch the price is ${Convert.ToDecimal(price2).ToString("0.00")}");
        Console.WriteLine($"Register: {age} years old, code {code} and gender: {gender}");
        Console.WriteLine($"Measured to eight decimal places {Convert.ToDecimal(measure).ToString("0.00000000")}");
        Console.WriteLine($"Measured to three decimal places {Convert.ToDecimal(measure).ToString("0.000")}");
        Console.WriteLine($"Measured with a comma {Convert.ToDecimal(measure).ToString("0.000")}"); // Como faz isso aqui usando virgula ao invés de ponto?
        */
        /* Exercício 2: Calcule a área de um trapézio e mostre o resultado com duas casas decimais
        double baseMaior;
        double baseMenor;
        double altura;
        double resultado; 
        
        Console.Write("Calcule a area de um trapezio\nInsira o valor da base maior: ");
        baseMaior = double.Parse(Console.ReadLine());
        Console.Write("Insira o valor da base menor: ");
        baseMenor = double.Parse(Console.ReadLine());
        Console.Write("Insira o valor da altura: ");
        altura = double.Parse(Console.ReadLine());
        
        resultado = ((baseMaior+baseMenor) * altura)/2;
        
        Console.Write($"O resultado ficou: {Convert.ToDecimal(resultado).ToString("0.00")}");
        */
        /* Exercício 3: Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
        int idFuncionario;
        double horasTrabalhadas;
        double salarioPorHora;
        double salarioTotal; 
        
        Console.Write("Numero do funcionario: ");
        idFuncionario = int.Parse(Console.ReadLine());
        Console.Write("Horas Trabalhadas: ");
        horasTrabalhadas = double.Parse(Console.ReadLine());
        Console.Write("Salario por hora: ");
        salarioPorHora = double.Parse(Console.ReadLine());
        
        salarioTotal = horasTrabalhadas * salarioPorHora;
        
        Console.WriteLine($"\nFuncionario: {idFuncionario}");
        Console.WriteLine($"Salario: U${Convert.ToDecimal(salarioTotal).ToString("0.00")}");
        */
        /* 
        Exercício 4: Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: 
        a) a área do triângulo retângulo que tem A por base e C por altura. 
        b) a área do círculo de raio C. (pi = 3.14159) 
        c) a área do trapézio que tem A e B por bases e C por altura. 
        d) a área do quadrado que tem lado B.
        e) a área do retângulo que tem lados A e B */
        /*
        double A;
        double B;
        double C;
        double resultado; 
        
        Console.Write("Calcule coisas\nInsira o valor de A: ");
        A = double.Parse(Console.ReadLine());
        Console.Write("Insira o valor de B: ");
        B = double.Parse(Console.ReadLine());
        Console.Write("Insira o valor de C: ");
        C = double.Parse(Console.ReadLine());
        
        resultado = (A*C)/2;
        Console.WriteLine($"Area do triangulo retangulo que tem A por base e C por altura: {Convert.ToDecimal(resultado).ToString("0.000")}");
        
        resultado = 3.14159*(Math.Pow(C, 2));
        Console.WriteLine($"Area do circulo de raio C: {Convert.ToDecimal(resultado).ToString("0.000")}");
        
        resultado = ((A+B)*C)/2;
        Console.WriteLine($"Area do trapezio que tem A e B por bases e C por altura: {Convert.ToDecimal(resultado).ToString("0.000")}");
        
        resultado = Math.Pow(B,2);
        Console.WriteLine($"Area do quadrado que tem lado B: {Convert.ToDecimal(resultado).ToString("0.000")}");
        
        resultado = A*B;
        Console.WriteLine($"Area do retangulo que tem lados A e B: {Convert.ToDecimal(resultado).ToString("0.000")}");
        */
        // Exercício 5: Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
        /*
        double A;
        double B;
        double C;
        double D;
        double resultado; 
        
        Console.Write("Calcule coisas\nInsira o valor de A: ");
        A = double.Parse(Console.ReadLine());
        Console.Write("Insira o valor de B: ");
        B = double.Parse(Console.ReadLine());
        Console.Write("Insira o valor de C: ");
        C = double.Parse(Console.ReadLine());
        Console.Write("Insira o valor de D: ");
        D = double.Parse(Console.ReadLine());
        
        resultado = (A*B)-(C*D);
        
        Console.WriteLine($"(A * B - C * D) = {Convert.ToDecimal(resultado).ToString("0.00")}");
        */
        // Exercício 6: Criem um programa que recebe o número X e imprime se o número é maior que dois , menor que dois ou igual a dois 
        /*
        int x;
        
        Console.Write("Insira o valor de X para fazer uma comparacao: ");
        x = int.Parse(Console.ReadLine());
        if(x>2){
            Console.WriteLine($"O valor que voce inseriu (x = {x}) e maior que 2");
        } else if (x<2) {
            Console.WriteLine($"O valor que voce inseriu (x = {x}) e menor que 2");
        } else {
            Console.WriteLine($"O valor que voce inseriu (x = {x}) e igual a 2");
        }
        */
        // Exercício 7: Criem um programa que recebe o número X e se o número não for  10 ele vai transformá lo em 10
        /*
        int x;
        
        Console.Write("Insira o valor de X para fazer uma comparacao: ");
        x = int.Parse(Console.ReadLine());
        if(x!=10){
            Console.WriteLine($"O valor que voce inseriu (x = {x}) e diferente de 10, logo, vai se tornar 10");
            x = 10;
        }  else {
            Console.WriteLine($"O valor que voce inseriu (x = {x}) e igual a 10, parabens :)");
        }
        Console.WriteLine($"O x ficou {x} no final");
        */
        // Exercício 8: Cria um algoritmo para verificar se um número e PAR ou IMPAR
        /*
        int x;
        
        Console.Write("Insira o valor de X para fazer uma comparacao: ");
        x = int.Parse(Console.ReadLine());
        if(x%2==0){
            Console.WriteLine($"O valor que voce inseriu (x = {x}) e PAR");
        }  else {
            Console.WriteLine($"O valor que voce inseriu (x = {x}) e IMPAR");
        }
        */
        // Exercício 9: O professor aplicou a avaliação em sua turma e deseja mostrar se o aluno foi aprovado (nota maior ou igual a 5) ou reprovado(nota menor que 5). Desenvolva o programa que leia a nota do aluno e gere a tela de saída com as informações solicitadas.
        /*
        Console.Write("Insira a nota do aluno para saber se foi aprovado ou reprovado: ");
        double nota = double.Parse(Console.ReadLine());
        if(nota >= 5.0){
            Console.WriteLine("Aluno Aprovado!");
        }  else {
            Console.WriteLine("Aluno Reprovado!");
        }
        */
        // Exercício 10: Uma operadora de telefonia cobra R$ 50.00 por um plano básico que dá direito a 100 minutos de telefone. Cada minuto que exceder a franquia de 100 minutos custa R$ 2.00. Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu, daí mostrar o valor a ser pago.
        /*
        Console.Write("Insira quantos minutos foram usados do seu plano pra saber quanto pagar: ");
        double minutos = double.Parse(Console.ReadLine());
        if(minutos<=100){
            Console.WriteLine("Valor a pagar: R$ 50.00");
        }  else {
            double valorExcedido = ((minutos - 100) * 2) + 50;
            Console.WriteLine($"Valor a pagar: R$ {Convert.ToDecimal(valorExcedido).ToString("0.00")}");
        }
        */
        /* 
        Exercício 11: Faça um programa que retorna a hora que for digitada e cumprimente de acordo com o horário.
        0 <= madrugada <6
        6 <= dia < 12
        12 <= tarde < 18
        18 <= noite <= 24
        */
        /*
        Console.Write("Que horas sao?\nHoras: ");
        int horas = int.Parse(Console.ReadLine());
        if(horas<0){
            Console.WriteLine("Horário inválido!");
        }else if (horas < 6){
            Console.WriteLine($"Agora são {horas} horas. Boa madrugada!");
        } else if (horas >= 6 && horas < 12){
            Console.WriteLine($"Agora são {horas} horas. Bom dia!");
        } else if (horas >= 12 && horas < 18){
            Console.WriteLine($"Agora são {horas} horas. Boa tarde!");
        } else if (horas >= 18 && horas < 24){
            Console.WriteLine($"Agora são {horas} horas. Boa noite!");
        } else {
            Console.WriteLine("Horário inválido!");
        }
        */
        // Exercício 12: Escreva um algoritmo que solicita ao usuário dois operandos e um código de operação (1 - Soma, 2 - Subtração, 3 - Divisão ou 4 - Multiplicação) e realiza a operação correspondente sobre os operandos fornecidos pelo usuár
        /*
        double resultado;
        
        Console.Write("Insira o valor de X e Y\nX:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y:");
        double y = double.Parse(Console.ReadLine());
        
        Console.Write("Escolha qual operação quer fazer\n(1) - Soma\n(2) - Subtracao\n(3) - Divisao\n(4) - Multiplicacao\nEscolha: ");
        int escolha = int.Parse(Console.ReadLine());
        switch(escolha){
            case(1):
            resultado = x+y;
            Console.WriteLine($"Resultado: {Convert.ToDecimal(resultado).ToString("0.00")}");
            break;
            
            case(2):
            resultado = x-y;
            Console.WriteLine($"Resultado: {Convert.ToDecimal(resultado).ToString("0.00")}");
            break;
            
            case(3):
            resultado = x/y;
            Console.WriteLine($"Resultado: {Convert.ToDecimal(resultado).ToString("0.00")}");
            break;
            
            case(4):
            resultado = x*y;
            Console.WriteLine($"Resultado: {Convert.ToDecimal(resultado).ToString("0.00")}");
            break;
            
            default:
            Console.WriteLine("Escolha invalida, tente novamente!");
            break;
        }
        */
    }
}
