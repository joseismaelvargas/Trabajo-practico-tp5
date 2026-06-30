// ejersicio 1
// using System.Numerics;

// Console.WriteLine("Ingrese la longitud del vector");
// int N=Convert.ToInt32(Console.ReadLine());
// int [] vector=new int[N];
// double sumavectores=0;
// int numero_mayor_promedio=0;
// for(int i = 0; i < N; i++)
// {
//     Console.WriteLine("Ingrese numeros");
//     vector[i]=Convert.ToInt32(Console.ReadLine());

// };
// Console.WriteLine("Elementos del vector");
// for(int i = 0; i < vector.Length; i++)
// {
//     sumavectores=sumavectores+vector[i];
//     Console.WriteLine(vector[i]);
// }
// double promedio=sumavectores/N;
// for(int i = 0; i < vector.Length; i++)
// {
//     if (vector[i] > promedio)
//     {
//         numero_mayor_promedio=numero_mayor_promedio+1;
//     }
// }

// Console.WriteLine("La suma de los vectores es "+sumavectores);
// Console.WriteLine("El promedio de los vectores es "+promedio);
// Console.WriteLine("numeros mayores al promedio "+numero_mayor_promedio);


// ejersicio2
// using System.Numerics;
// int posiciones=5;
// int [] vector=new int[posiciones];
// int impar1=0;
// int impar2=0;
// int mayor=0;
// for(int i = 0; i < posiciones; i++)
// {
//  Random random = new Random();
//  int numero_random=random.Next(1,90);  
//   vector[i]=numero_random;
// }

// for(int i = 0; i < vector.Length; i++)
// {

//     Console.WriteLine(vector[i]);
   
//     if (vector[i] > mayor||i== 2)
//     {
//            mayor=vector[i];
//         impar1=vector[i];
//     }else if ( i==4)
//     {
//         impar2=vector[i];
//     }

// }

// Console.WriteLine("La suma de las posiciones impares es "+(impar1+impar2));
// Console.WriteLine($"El numero mayor es {mayor}"); 
// ejersicio3
// Console.WriteLine("Ingrese N cantidad");
// int N= Convert.ToInt32(Console.ReadLine());
// string[] nombres=new string [N];

// for(int i=0; i < N; i++)
// {
//     Console.WriteLine("Ingrese NOMBRES");
//     nombres[i]=Console.ReadLine();

// }

// Console.WriteLine("Buscar nombre");
// var buscador=Console.ReadLine();

// for(int i = 0; i < nombres.Length; i++)
// {
//     if (nombres[i] == buscador)
//     {
//         Console.WriteLine("el nombre fue encontrado");
//         Console.WriteLine(nombres[i] +" y esta en la posicion "+i);
//     }
//     else
//     {
//         Console.WriteLine("El nombre no fue encontrado");
//     }
// }

// Fuciones
static void Bienvenida()
{
    Console.WriteLine("Bienvenido a superMax Todos los dias 20% descuento pagando en efectivo ");
}
static void Gracias()
{
    Console.WriteLine("Gracias por su compra");
}
Bienvenida();
Gracias();