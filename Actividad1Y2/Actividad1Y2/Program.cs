using Actividad1Y2.Clases;


Pila Pila = new Pila(10);

Pila.añadir("Celular");
Pila.añadir("Computadora");
Pila.añadir("Televisor");

Cola Cola = new Cola();
Cola.añadir("Celular Cola");
Cola.añadir("Computadora Cola");
Cola.añadir("Televisor Cola");


int menu = 0;
do
{
    Console.WriteLine("-------------------------------------");

    Console.WriteLine("1- Verificas estado de la pila");
    Console.WriteLine("2- Primer Elemento");
    Console.WriteLine("3- Extraer elemento");
    Console.WriteLine("COLAS");
    Console.WriteLine("4- Verificar estado de la cola");
    Console.WriteLine("5- Primer elemento de la cola");
    Console.WriteLine("6- Extraer elemento la cola");
    Console.WriteLine("-------------------------------------");

    menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1:
            Console.WriteLine(Pila.estaVacia());
            break;
        case 2:
            object newObjet = Pila.primero();

            Console.WriteLine(newObjet);
            break;
        case 3:
            object objetquitado = Pila.extraer();
            Console.WriteLine(objetquitado);
            break;
        case 4:
            Console.WriteLine(Cola.estaVacia());
            break;
        case 5:
            object newObjerCola = Cola.primero();
            Console.WriteLine(newObjerCola);
            break;
        case 6:
            object objetoQuitadoCola = Cola.extraer();
            Console.WriteLine(objetoQuitadoCola);
            break;
        default:
            menu = 0;
            break;
    }
    

} while(menu != 0);
