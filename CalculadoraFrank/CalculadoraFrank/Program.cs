class Calculadora
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Calculaodora");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multi");
            Console.WriteLine("4. Divi");
            Console.WriteLine("5. Raíz cuadrada");
            Console.WriteLine("6. Exponente (potencia)");
            Console.WriteLine("7. Salir");

            string opcion = Console.ReadLine();

            double num1 = 0, num2 = 0;

            if (opcion == "7")
            {
                Console.WriteLine("Gracias por usar");

            }
            else
            {
                Console.Write("Ingrese el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }


                Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Resultado: {num1 + num2}");
                    break;
                    case "2":
                    Console.WriteLine($"Resultado: {num1 - num2}");
                    break;
                    case "3":
                    Console.WriteLine($"Resultado: {num1 * num2}");
                    break;
                    case "4":
                    if (num2 != 0)
                        Console.WriteLine($"Resultado: {num1 / num2}");
                    else
                        Console.WriteLine("Error: división por cero.");
                    break;
                    case "5":
                    if (num1 >= 0)
                        Console.WriteLine($"Resultado: {Math.Sqrt(numfrank)}");
                    else
                        Console.WriteLine(" no se puede calcular la raíz cuadrada de un número negativo.");
                    break;
                    case "6":
                    Console.WriteLine($"Resultado: {Math.Pow(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;




            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();


        }
    }
}  


