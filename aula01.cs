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
        
        Console.Write("Insira o valor de X e Y\nX: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y: ");
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
        // Exercício 13: Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem  (x = y = 0). Se o ponto estiver na origem, escreva a mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
        /*
        Console.Write("Insira o valor de X e Y para determinar um ponto (X,Y)\nX: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y: ");
        double y = double.Parse(Console.ReadLine());
        
        if(x==0&&y==0){
            Console.WriteLine($"O ponto ({Convert.ToDecimal(x).ToString("0.0")},{Convert.ToDecimal(y).ToString("0.0")}) esta na origem");
        } else if (x==0 && y!=0){
            Console.WriteLine($"O ponto ({Convert.ToDecimal(x).ToString("0.0")},{Convert.ToDecimal(y).ToString("0.0")}) esta no eixo X");
        } else if (x!=0 && y==0){
            Console.WriteLine($"O ponto ({Convert.ToDecimal(x).ToString("0.0")},{Convert.ToDecimal(y).ToString("0.0")}) esta no eixo Y");
        } else if (x>0 && y>0){
            Console.WriteLine($"O ponto ({Convert.ToDecimal(x).ToString("0.0")},{Convert.ToDecimal(y).ToString("0.0")}) esta no primeiro quadrante");
        } else if (x<0 && y>0){
            Console.WriteLine($"O ponto ({Convert.ToDecimal(x).ToString("0.0")},{Convert.ToDecimal(y).ToString("0.0")}) esta no segundo quadrante");
        } else if (x<0 && y<0){
            Console.WriteLine($"O ponto ({Convert.ToDecimal(x).ToString("0.0")},{Convert.ToDecimal(y).ToString("0.0")}) esta no terceiro quadrante");
        } else if (x>0 && y<0){
            Console.WriteLine($"O ponto ({Convert.ToDecimal(x).ToString("0.0")},{Convert.ToDecimal(y).ToString("0.0")}) esta no quarto quadrante");
        }
        */
        // Exercício 14: Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Inválida". Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
        /*
        string tentativa = "";
        
        Console.Write("Defina uma senha: ");
        string senha = Console.ReadLine();
        
        while(tentativa!=senha){
            Console.Write("Tente acertar a senha: ");
            tentativa = Console.ReadLine();
            if(tentativa!=senha){
                Console.WriteLine("Senha invalida");
            } else {
                Console.WriteLine("Acesso Permitido");
            }
        }
        */
        // Exercício 15: Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.
        /*
        int preferencia = 0;
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        
        Console.WriteLine("Preferencia de combustivel abastecido!\nInsira o numero correspondente a o tipo de combustivel que o cliente prefere:\n(1) - Alcool\n(2) - Gasolina\n(3) - Diesel\n(4) - Fim");

        while(preferencia!=4){
            Console.Write("Escolha: ");
            preferencia = int.Parse(Console.ReadLine());
            if(preferencia<1 || preferencia>4){
                Console.WriteLine("O numero inserido e invalido! Tente novamente!");
                continue;
            } else {
                if(preferencia==1){
                    alcool++;
                } else if(preferencia==2){
                    gasolina++;
                } else if(preferencia==3){
                    diesel++;
                }
            }
        }
        Console.Write($"MUITO OBRIGADO!\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        */
        // Exercicio 16: Achar o maior e o menor número de uma série de números inteiros positivos fornecidos pelo usuário via teclado. O programa deve solicitar valores até que o usuário entre com -1. (Usando while e condicionais)
        /*
        int escolha = 0;
        int menor = int.MaxValue;
        int maior = 0;
        
        Console.WriteLine("Digite valores inteiros e positivos para saber o maior e o menor deles\nDigite (-1) para sair");

        while(escolha!=-1){
            Console.Write("Escolha: ");
            escolha = int.Parse(Console.ReadLine());
            
            if(escolha==-1){
                break;
            } else if(escolha<-1){
                Console.WriteLine("Escolha um valor inteiro e positivo!");
                continue;
            }
            
            if(escolha<menor) {
                menor = escolha;
            }
            if(escolha>maior) {
                maior = escolha;
            }
        }
        Console.Write($"\nMaior valor: {maior}\nMenor valor: {menor}");
        */
        // Exercício 17: Escreva um algoritmo que solicita ao usuário valores inteiros positivos N e conta a quantidade de números pares e ímpares digitados. Quando o usuário digitar o valor -1 o programa deve parar. O algoritmo deve mostrar ao final o total de números pares e ímpares digitados. (Usando do ... while)
        /*
        int escolha = 0;
        int pares = 0;
        int impares = 0;
        
        Console.WriteLine("Digite valores inteiros e positivos para saber o quantos sao pares ou impares\nDigite (-1) para sair");

        do {
            Console.Write("Escolha: ");
            escolha = int.Parse(Console.ReadLine());
            
            if(escolha==-1){
                break;
            } else if(escolha<-1){
                Console.WriteLine("Escolha um valor inteiro e positivo!");
                continue;
            }
            
            if(escolha%2==0) {
                pares++;
            } else {
                impares++;
            }
        } while(escolha!=-1);
        
        Console.Write($"\nPares: {pares}\nImpares: {impares}");
        */
        // Exercicio 18: Fazer um programa para ler uma temperatura em Celsius e mostrar o equivalente em Fahrenheit. Perguntar se o usuário deseja repetir (s/n). Caso o usuário digite "s", repetir o programa.
        /*
        double c = 0;
        char escolha = 's';
        
        Console.Write("Conversor de Celsius para Fahrenheit\n");
        
        while(escolha!='n'){
            Console.Write("Digite a temperatura: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Equivalente em Fahrenheit: {Convert.ToDecimal(((9*c)/5)+32).ToString("0.0")}");
            Console.Write("Deseja repetir(s/n)? ");
            escolha = char.Parse(Console.ReadLine());
        }
        */
        // Exercicios 19: Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações
        /*
        int dentro = 0;
        int fora = 0;
        
        Console.WriteLine("Digite um valor N\nEsse valor vai ser quantos numeros você vai digitar");
        int N = int.Parse(Console.ReadLine());
        
        for(int i=0;i<N;i++){
            Console.Write("Digite um valor: ");
            int x = int.Parse(Console.ReadLine());
            if(x>=10 && x<=20){
                dentro++;
            } else {
                fora++;
            }
        }
        Console.Write($"Valores dentro do intervalo [10,20]: {dentro}\nValores fora do intervallo[10,20]: {fora}");
        */
        // Exercício 20: Leia um valor inteiro X. Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
        /*
        Console.WriteLine("Digite um valor N\nEsse valor vai ser quantos numeros impares vai aparecer");
        int N = int.Parse(Console.ReadLine());
        Console.Write("\n");
        for(int i=0;i<N;i++){
            if(i%2!=0){
                Console.WriteLine(i);
            }
        }
        */
        // Exercício 21: Ler um número inteiro N e calcular todos os seus divisores.
        /*
        Console.WriteLine("Digite um valor N\nEsse valor vai ser quantos divisores um numero tem");
        int N = int.Parse(Console.ReadLine());
        Console.Write("\n");
        for(int i=1;i<=N;i++){
            if(N%i==0){
                Console.WriteLine(i);
            }
        }
        */
        // Exercicio 22: Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. Lembrando que, por definição, fatorial de 0 é 1.
        /*
        int fatorial = 1;
        
        Console.WriteLine("Digite um valor N\nSera feito o fatorial desse valor");
        int N = int.Parse(Console.ReadLine());
        if(N==0){
            Console.WriteLine(1);
        } else {
            for(int i=1;i<=N;i++){
                fatorial*=i;
            }
            Console.WriteLine("Resultado: " + fatorial);
        }
        */
        // Exercicio 23: Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.
        /*
        int quadrado = 0;
        int cubo = 0;
        Console.WriteLine("Digite um valor N\n");
        int N = int.Parse(Console.ReadLine());
        for(int i=1;i<=N;i++){
            quadrado = (i*i);
            cubo = (i*i*i);
            Console.WriteLine($"{i} {quadrado} {cubo}");
        }
        */
    }
}
