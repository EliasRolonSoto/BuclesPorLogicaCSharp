
////Generar un numero random entre 1 y 10 hasta que salga el numero 7
////Primero genera los numeros luego chequea la condicion de salida
//Random random = new Random();

//int current = 0;

//do
//{
//    current = random.Next(1, 11);

//    Console.WriteLine(current);

//} while (current != 7);

//------------------------------

////Generar un numero random entre 1 y 10 hasta que salga un numero menor a 3
////Primero chequea la condicion de salida luego genera los numeros
//Random random = new Random();
//int current = random.Next(1, 11);

///*
//do
//{
//    current = random.Next(1, 11);
//    Console.WriteLine(current);
//} while (current != 7);
//*/

//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {current}");


//------------------------------

//Random random = new Random();
//int current = random.Next(1, 11);

//do
//{
//    current = random.Next(1, 11); // Genera un número aleatorio entre 1 y 10

//    if (current >= 8) continue; // Salta la iteración si el número es mayor o igual a 8

//    Console.WriteLine(current);
//} while (current != 7); // Continúa hasta que el número generado sea 7

///*
//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {current}");
//*/

//------------------------------

//Desafio Batalla de Troll
/*En algunos juegos de rol, el personaje del jugador se enfrenta a personajes que no son de jugador, normalmente monstruos o "los malos".
A veces, en una batalla cada personaje genera un valor aleatorio mediante dados y ese valor se resta de la puntuación de salud del adversario.
Cuando la salud de cualquiera de los personajes llega a cero, pierden.

En este desafío, esa interacción se reducirá a lo más básico. 
Un héroe y un monstruo comienzan con la misma puntuación de salud. 
Durante el turno del héroe, se generará un valor aleatorio que se restará de la salud del monstruo. 
Si la salud del monstruo es mayor que cero, tomará su turno y atacará al héroe. 
Mientras que la salud del héroe y del monstruo sea mayor que cero, el combate se reanudará.

Desafío de código: escribir código para implementar las reglas de juego
Estas son las reglas para el juego de batalla que necesita implementar en el proyecto de código:

Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
El héroe y el monstruo comenzarán con 10 puntos de salud.
Todos los ataques tendrán un valor comprendido entre 1 y 10.
El héroe ataca primero.
Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
Si la salud del monstruo es mayor que 0, puede atacar al héroe.
Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
Imprima el ganador.*/

//Random dado = new Random();
//int saludDelHeroe = 10;
//int saludDelMonstruo = 10;

//do
//{
//    //Turno del héroe
//    int tirada = dado.Next(1,10);
//    saludDelMonstruo -= tirada;
//    Console.WriteLine($"El héroe ataca al monstruo y le quita {tirada} puntos de salud. Salud restante del monstruo: {saludDelMonstruo}");

//    if (saludDelMonstruo <= 0)
//    {
//        Console.WriteLine("El monstruo se ha debilitado");
//        continue;
//    }

//    //Turno del monstruo
//    tirada = dado.Next(1, 10);
//    saludDelHeroe -= tirada;
//    Console.WriteLine($"El monstruo ataca al héroe y le quita {tirada} puntos de salud. Salud restante del héroe: {saludDelHeroe}");

//    if(saludDelHeroe <= 0)
//    {
//        Console.WriteLine("El héroe se ha debilitado");
//        continue;
//    }


//} while (saludDelMonstruo > 0 && saludDelHeroe > 0) ;


//Console.WriteLine(saludDelHeroe > 0 ? "El héroe ha ganado la batalla" : "El monstruo ha ganado la batalla");


//------------------------------

////Ejemplo de entrada de Usuario:
//string? readResult; // Variable para almacenar la entrada del usuario que puede ser nula
//bool validEntry = false;
//Console.WriteLine("Enter a string containing at least three characters:");
//do
//{
//    readResult = Console.ReadLine();
//    if (readResult != null)
//    {
//        if (readResult.Length >= 3)
//        {
//            validEntry = true;
//        }
//        else
//        {
//            Console.WriteLine("Your input is invalid, please try again.");
//        }
//    }
//} while (validEntry == false); // Continua solicitando hasta que el usuario ingrese una cadena válida con al menos tres caracteres

//// Capturar un input que debe ser numerico -> o sea que cumpla con el TryParse y que tenga al menos 3 caracteres
//int numericValue = 0;
//bool validNumber = false;
//string? readResult;
//do
//{
//    Console.WriteLine("Ingrese un numero: (al menos 3 caracteres)");
//    readResult = Console.ReadLine();
//    if (validNumber == false && readResult.Length>=3)
//    {
//        validNumber = int.TryParse(readResult, out numericValue);
//    }


//}while (validNumber == false);



//------------------------------

//Ejercicio 1: 
/*Estas son las condiciones que el primer proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración: la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor de enteros entre 5 y 10.

Dentro del bloque de iteración:

La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
La solución debe asegurarse de que la entrada es una representación válida de un entero.
Si el valor del entero no está comprendido entre 5 y 10, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor del entero entre 5 y 10.
La solución debe garantizar que el valor de enteros está comprendido entre 5 y 10 antes de salir de la iteración.
*/

//Console.WriteLine("Ingrese un valor entero entre 5 y 10:");
//int userInput = 0;
//bool isValidInput = false;
//do
//{
//    userInput = int.TryParse(Console.ReadLine(), out userInput) ? userInput : 0;// Verifica si la entrada es un entero válido, si no lo es, asigna 0
//    if (10 >= userInput && userInput >= 5)// Verifica si el valor ingresado está entre 5 y 10
//    {
//        isValidInput = true;
//        Console.WriteLine($"El valor ingresado es: {userInput}, y esto es valido.");
//        continue; //Si la condicion se cumple, se sale del bucle y se continua con el resto del programa
//    }
//    else
//    {
//        Console.WriteLine("El valor ingresado no es valido, ingrese un valor entero entre 5 y 10:");
//    }

//    } while (!isValidInput); // Continua solicitando hasta que el usuario ingrese un valor válido entre 5 y 10


//Ejercicio 2:
/*Estas son las condiciones que el segundo proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración, la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario uno de los tres nombres de rol: Administrador, Director o Usuario.

Dentro del bloque de iteración:

La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
La solución debe garantizar que el valor especificado coincide con una de las tres opciones de rol.
La solución debe usar el método Trim() en el valor de entrada para omitir los caracteres de espacio iniciales y finales.
La solución debe usar el método ToLower() en el valor de entrada para omitir el caso.
Si el valor especificado no coincide con una de las opciones de rol, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario una entrada válida.
Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.

*/
//Console.WriteLine("Ingrese uno de los siguientes roles: Administrador, Director o Usuario:");
//string? userInput = null;
//string[] validRoles = { "administrador", "director", "usuario" };
//bool isValidRole = false;
//do
//{
//    userInput = Console.ReadLine().Trim().ToLower();
//    if (userInput!=null)
//    {
//        if (Array.Exists(validRoles, role => role == userInput)) // Verifica si el valor ingresado coincide con uno de los roles válidos
//        {

//            isValidRole = true;
//            continue; // Si la condición se cumple, se sale del bucle
//        }
//        else
//        {
//            Console.WriteLine("El valor ingresado no es valido, ingrese uno de los siguientes roles: Administrador, Director o Usuario:");
//        }
//    }
//}while( !isValidRole );

//Console.WriteLine($"El rol ingresado es: {userInput}, y esto es valido.");


//Ejercicio 3:
/*Estas son las condiciones que el tercer proyecto de codificación debe implementar:

La solución debe usar la siguiente matriz de cadenas para representar la entrada en la lógica de codificación:
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
La solución debe declarar una variable de enteros denominada periodLocation que se pueda usar para contener la ubicación del carácter de punto dentro de una cadena.

La solución debe incluir un bucle externo foreach o for que se pueda usar para procesar cada elemento de cadena de la matriz. 
La variable de cadena que procesará dentro de los bucles debe denominarse myString.

En el bucle externo, la solución debe usar el método IndexOf() de la clase String para obtener la ubicación del primer carácter de punto de la variable myString.
La llamada al método debe ser similar a myString.IndexOf("."). Si no hay ningún carácter de punto en la cadena, se devolverá un valor de -1.

La solución debe incluir un bucle interno do-while o while que se pueda usar para procesar la variable myString.

En el bucle interno, la solución debe extraer y mostrar (escribir en la consola) cada frase contenida en cada una de las cadenas que se procesan.

En el bucle interno, la solución no debe mostrar el carácter de punto.

En el bucle interno, la solución debe usar los métodos Remove(), Substring() y TrimStart() para procesar la información de cadena.

*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // Extraer y mostrar cada frase contenida en cada una de las cadenas que se procesan
    while (periodLocation != -1)
    {

        // mySentence es igual a la cadena, menos todo lo que esta despues de periodLocation
        mySentence = myString.Remove(periodLocation);

        // A myString se le quita todo lo que esta antes del "periodLocation", incluido el punto
        myString = myString.Substring(periodLocation + 1);

        // quita los espacios en blanco al principio de la cadena
        myString = myString.TrimStart();

        // vuelvo a dar valor a periodLocation para que me diga la posicion del siguiente punto (si existe), si no existe devuelve -1 que es lo que rompe el loop while
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}