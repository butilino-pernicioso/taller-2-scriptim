# Participantes:
- Emmanuel Lora
- Juan Esteban Calle
- Nicolás Parra

# taller-2-scriptim
1. Explicar por medio de un ejemplo de mínimo 5 funciones el concepto de delegado
2. Consultar y crear un ejemplo donde se evidencie el uso de event en  **c#** 
3. Consultar que es singleton, sus pros y contras, como se implementa en  **c#** y como se implementa en  **unity**
4. Investigar y explicar un patrón de poo y un principio 
5. consultar y explicar el ciclo de vida de un script en  **unity**
6. hacer 30 commits

## solucion
3. consultar y crear un ejemplo donde se evidencie el uso de event en c#
   Events.
Un evento es un mensaje que envía un objeto cuando ocurre una acción. La acción podría deberse a la interacción del usuario, como hacer clic en un botón, o podría derivarse de cualquier otra lógica del programa, como el cambio del valor de una propiedad.

punto extra: 30 funciones 
ej1:  
firma:
Public delegate void x();
funcion:
public void Equis()
{

}

ej2:
firma:
public delegate int[] y(bool x, float y);
Funcion:
Public int[] y((bool x, float y);
{
return new int[] {1, 2, 3};
}

ej3:
firma:
public int sumar(int numero1, int numero2)
funcion:
public static int Sumar(int numero1, int numero2)
{
    return numero1 + numero2;
}

ej4: 
firma:
public int restar(int numero1, int numero2)
funcion:
public static int Restar(int numero1, int numero2)
{
    return numero1 - numero2;
}

ej5:
public static duble sumarduble(duble numero1,duble numero2)

tarea: numeros, arreglos, objetos, matrices
eje6:

public delegate string[] Vehiculo(string caballo);

public static string[] Vehiculofuncion(string caballo)
{
retrum moto;
}



