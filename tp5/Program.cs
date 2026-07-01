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

// ejersicio4

// using System.Dynamic;

// Console.WriteLine("INGRSE LA CANTIDAD DE COLUMNAS");
// int N =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("###############################");

// int  [,] matriz2=new int[2,N];
// int numerospares=0;
// // inicializa la matriz en 0
// int numeromenor=matriz2[0,0];

// for(int i = 0; i < 2; i++)
// {
//     for(int j = 0; j < N; j++)
//     {
//         Random random=new Random();
//         int numeros=random.Next(10,20);
//         matriz2[i,j]=numeros;
//     }
// }

// // mostrar matriz
// for(int i = 0; i < 2; i++)
// {
//     for (int j=0;j<N;j++)
//     {
//         Console.WriteLine(matriz2[i,j]+"\t");
       

//         if (matriz2[i, j] < numeromenor)
//         {
//            numeromenor=matriz2[i,j];
//         }
//         if (matriz2[i, j] % 2 == 0)
//         {
//             numerospares++;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("###############################");
// Console.WriteLine("cantidad de numeros pares "+numerospares);
// Console.WriteLine("El numeros menor es "+numeromenor);

// ejersicio 5
Console.WriteLine("##############################################");
Console.WriteLine("Ingrese cantidad de filas");
int F=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese cantidad de Columnas");
int C=Convert.ToInt32(Console.ReadLine());
int numerospares=0;
int numerosImapares=0;
int [,]matriz3=new int[F,C];
for (int i=0;i<F;i++)
{
    
    for(int j= 0; j < C; j++)
    {
      Console.WriteLine($"Ingrese el valor en la posicion |{i}|{j}|");
       int numeros=Convert.ToInt32(Console.ReadLine());
        matriz3[i,j]=numeros;
      
     
    }
}
Console.WriteLine("mostrar matriz");

for (int i=0;i <F;i++)
{for(int j = 0; j < C; j++)
    {
       Console.WriteLine(matriz3[i,j]);
        if (matriz3[i, j] % 2 == 0)
        {
            numerospares++;
        }
        else
        {
            numerosImapares++;
        }
    }
   
}
double porcentaje=(double)numerospares/matriz3.Length;
Console.WriteLine("##############################################");
Console.WriteLine("la cantidad de numeros pares son "+numerospares);
Console.WriteLine("la cantidad de numeros Impares son "+numerosImapares);
Console.WriteLine("El porcentaje de numeros pares es  "+porcentaje*100+"%");
// Fuciones
// static void Bienvenida()
// {
//     Console.WriteLine("Bienvenido a superMax Todos los dias 20% descuento pagando en efectivo ");
// }
// static void Gracias()
// {
//     Console.WriteLine("Gracias por su compra");
// }
// Bienvenida();
// Gracias();

// static void Matrices(int a,int)
// {

// }
// using System.IO.Compression;

// int[,]matriz=new int[5,5];
// for(int i = 0; i < 5; i++)
// {
//     for(int j = 0; j < 5; j++)
//     {
//         if (i == 2)
//         {
//             matriz[i,j]=1;

//         }
//         else
//         {
//             matriz[i,j]=0;
//         }
//     }
// }
// for(int i = 0; i < 5; i++)
// {
//     for( int j = 0; j < 5; j++)
//     {
//         Console.WriteLine(matriz[i,j]);
//     }
//     Console.WriteLine();
// }

// Area de un triangulo

// static double AreadelTriangulo(double vase, double altura)
// {
//     double area;
//     area= vase * altura;
//     return area;
// }
// static void Calculador(double a,double b)
// {
//     double resultado=AreadelTriangulo(a,b);
//     Console .WriteLine("El area del triangulo es "+resultado);
// }  
// Calculador(3.4,5.5);