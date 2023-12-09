﻿// Pedro Henrique de Souza Ramos
/*Crie uma lista de inteiros utilizando o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.
No for, comece o índice em 0 e incremente a cada iteração. Defina a condição de continuação do loop como i < numeros.Count, ou seja, o loop continuará enquanto 
o valor de i for menor do que o número de elementos na lista. Acesse o valor de cada elemento utilizando a sintaxe numeros[i].
Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da lista através do índice i, é utilizado o foreach para percorrer a lista e 
acessar diretamente cada elemento com a variável número. Em seguida, é verificado se o número é par utilizando o operador de módulo (%) e, caso seja, o número é impresso no console.
*/
Console.WriteLine("Listando Números Interios!");

//List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine("Digite a quantidade que deseja exibir de números pares: ");
string numeros = Console.ReadLine()!;
Convert.ToInt64(numeros, 0);

foreach (int numero in numeros)
{
    if (numero % 2 == 0) //Dividi o número passado por 2 e caso retornar 0 ele é par
    {
        Console.WriteLine($"Número par : {numero}");
    }
}

