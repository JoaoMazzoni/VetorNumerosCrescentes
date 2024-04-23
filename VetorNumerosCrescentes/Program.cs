int size = 10;
int aux = 0;
int[] vetorOriginal = new int[size];
int[] vetorOrdenado = new int[size];

for (int i = 0; i < size; i++)
{
    vetorOriginal[i] = new Random().Next(0, 100); //vetorOriginal recebe os numeros aleatorios
    vetorOrdenado[i] = vetorOriginal[i]; // Copia para o vetorOrdenado
}

for(int i = 0; i < size; i++)
{
    Console.WriteLine(vetorOriginal[i] + " ");
}

Console.ReadKey();


for (int referencia = 0; referencia < size; referencia++)
{
    for(int comparacao = referencia + 1; comparacao < size; comparacao++)
    {
        if (vetorOrdenado[referencia] > vetorOrdenado[comparacao])
        {
            aux = vetorOrdenado[referencia];
            vetorOrdenado[referencia] = vetorOrdenado[comparacao];
            vetorOrdenado[comparacao] = aux;
        }
    }
}


for (int i = 0; i < size; i++)
{
    Console.WriteLine(vetorOrdenado[i] + " ");
}


Console.ReadKey();



































//int[] vetor = new int[5];
//int[] vetor2 = new int[5];

//for(int i = 0; i < 5; i++)
//{
//    //Console.Write($"Digite o {i + 1}º número: ");
//    //vetor[i] = int.Parse(Console.ReadLine());
//    vetor[i] = new Random().Next(0, 100);    
//}



//for (int i = 0; i < 5; i++)
//{
//    int menor = vetor[i]; //Guardando o número do vetor na variavel menor.
//    int posMenor = i; // Guardando a posição do número.

//    for (int j = i + 1; j < 5; j++) //Usando novo incremento para comparar
//    {                               // Posição |j| vai comparar com a próxima posição a ela |i+1| ou seja compara o (0) do |j| com o (1) do |i|

//        if (vetor[j] < menor) //Se o valor de |j| for < que o valor guardado em |menor|
//        { 
//            menor = vetor[j]; //Menor guarda esse valor do vetor.
//            posMenor = j; //Guarda  a posição do |j|
//        }
//    }

//    vetor2[i] = vetor[i];
//    vetor[i] = menor;
//    vetor[posMenor] = vetor2[i];
//}
//Console.WriteLine("\nNúmeros ordenados: ");
//for (int i = 0; i < 5; i++)
//{
//    Console.Write($"{vetor[i]} ");

//}






































//int[] numeros = new int[5];
//int menor;

//for (int i = 0; i < 5; i++)
//{ 
//    numeros[i] = new Random().Next(0, 100);
//    Console.WriteLine("Números escolhidos: {0}", numeros[i]);
//}

//// Ordenando os números em ordem crescente
//for (int i = 0; i < 5 - 1; i++)
//{
//    for (int j = 0; j < 5 - i - 1; j++)
//    {
//        if (numeros[j] > numeros[j + 1])
//        {
//            // Troca os elementos se estiverem fora de ordem
//            menor = numeros[j];
//            numeros[j] = numeros[j + 1];
//            numeros[j + 1] = menor;
//        }
//    }
//}

//// Exibindo os números em ordem crescente
//Console.WriteLine("\nNúmeros em ordem crescente:");
//for (int i = 0; i < 5; i++)
//{
//    Console.Write(numeros[i] + " ");
//}

//Console.ReadKey();
