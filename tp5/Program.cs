// ejersicio 1
Console.WriteLine("Ingrese la longitud del vector");
int N=Convert.ToInt32(Console.ReadLine());
int [] vector=new int[N];
double sumavectores=0;
int numero_mayor_promedio=0;
for(int i = 0; i < N; i++)
{
    Console.WriteLine("Ingrese numeros");
    vector[i]=Convert.ToInt32(Console.ReadLine());

};
Console.WriteLine("Elementos del vector");
for(int i = 0; i < vector.Length; i++)
{
    sumavectores=sumavectores+vector[i];
    Console.WriteLine(vector[i]);
}
double promedio=sumavectores/N;
for(int i = 0; i < vector.Length; i++)
{
    if (vector[i] > promedio)
    {
        numero_mayor_promedio=numero_mayor_promedio+1;
    }
}

Console.WriteLine("La suma de los vectores es "+sumavectores);
Console.WriteLine("El promedio de los vectores es "+promedio);
Console.WriteLine("numeros mayores al promedio "+numero_mayor_promedio);