/*
 Creare un'applicazione console che filtra un elenco di numeri interi. 
 Dovrebbe selezionare solo numeri dispari da un elenco di 1000 numeri interi casuali. 
 Utilizzare la sintassi di query di LINQ per risolvere questo esercizio.
 */


Random random = new Random();

List<int> listaInteri = Enumerable.Range(1,1000).Select(numeroCauale => random.Next(numeroCauale)).Where(numero => numero % 2 != 0).ToList();

foreach(int numero in listaInteri)
{
    Console.WriteLine(numero);
}