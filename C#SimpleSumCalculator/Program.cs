//Chiedo il primo numero
Console.WriteLine("Inserisci il primo numero: ");
//Ricevo il primo numero in formato stringa e lo converto a integer
int primoNumero = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero: ");
//Ricevo il secondo numero in formato stringa e lo converto a integer
int secondoNumero = int.Parse(Console.ReadLine());

//sommo i due numeri
int somma = primoNumero + secondoNumero;

Console.WriteLine(somma);

Console.ReadKey();