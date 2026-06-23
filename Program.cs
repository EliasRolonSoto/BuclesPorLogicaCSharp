
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

/*
 */