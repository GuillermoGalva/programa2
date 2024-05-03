using programa2.Class;
using System;

class Program
{
    static void Main()
    {
        int num1, num2, num3, num4;

        try
        {

            Console.WriteLine("Ingrese el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto número:");
            num4 = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Por favor ingrese un número entero válido.");
            return;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El número ingresado es demasiado grande.");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return;
        }


        int suma = Calculadora0.CalcularSuma(num1, num2);

        
        int producto = Calculadora0.CalcularProducto(num3, num4);

      
        Console.WriteLine($"La suma de los dos primeros números es: {suma}");
        Console.WriteLine($"El producto del tercer y cuarto número es: {producto}");
    }
}
