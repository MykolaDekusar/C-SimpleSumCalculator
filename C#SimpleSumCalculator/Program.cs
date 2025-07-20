//Chiedo il primo numero
Console.WriteLine("Inserisci il primo numero: ");
//Ricevo il primo numero in formato stringa e lo converto a integer
int primoNumero = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero: ");
//Ricevo il secondo numero in formato stringa e lo converto a integer
int secondoNumero = int.Parse(Console.ReadLine());

//sommo i due numeri
int somma = primoNumero + secondoNumero;

Console.WriteLine($"La somma di {primoNumero} + {secondoNumero} è = {somma}");

//Ora usiamo i numeri con la virgola
//Chiedo il primo numero
Console.WriteLine("Inserisci il primo numero: ");
//Ricevo il primo numero in formato stringa e lo converto a integer
double terzoNumero = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero: ");
//Ricevo il secondo numero in formato stringa e lo converto a integer
double quartoNumero = double.Parse(Console.ReadLine());

//sommo i due numeri
double sommaDue = terzoNumero + quartoNumero;

Console.WriteLine($"La somma di {terzoNumero} + {quartoNumero} è = {sommaDue}");


Console.ReadKey();