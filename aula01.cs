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
        /* Exercício 4: Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: 
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
    }
}
