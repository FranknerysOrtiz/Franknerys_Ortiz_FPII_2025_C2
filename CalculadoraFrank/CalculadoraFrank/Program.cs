class Calculadora
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Calculaodora 2025-0073");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multi");
            Console.WriteLine("4. Divi");
            Console.WriteLine("5. Raíz cuadrada");
            Console.WriteLine("6. Exponente (potencia)");
            Console.WriteLine("7. Salir");

            string opcion = Console.ReadLine();

            double numfrank = 0, numOrtiz = 0;

            if (opcion == "7")
            {
                Console.WriteLine("Gracias por usar");

            }
            else
            {
                Console.Write("Ingrese el primer número: ");
                numfrank = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                numOrtiz = Convert.ToDouble(Console.ReadLine());
            }


                Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Resultado: {numfrank + numOrtiz}");
                    break;
                    case "2":
                    Console.WriteLine($"Resultado: {numfrank - numOrtiz}");
                    break;
                    case "3":
                    Console.WriteLine($"Resultado: {numfrank * numOrtiz}");
                    break;
                    case "4":
                    if (numOrtiz != 0)
                        Console.WriteLine($"Resultado: {numfrank / numOrtiz}");
                    else
                        Console.WriteLine("Error: división por cero.");
                    break;
                    case "5":
                    if (numfrank >= 0)
                        Console.WriteLine($"Resultado: {Math.Sqrt(numfrank)}");
                    else
                        Console.WriteLine(" no se puede calcular la raíz cuadrada de un número negativo.");
                    break;
                    case "6":
                    Console.WriteLine($"Resultado: {Math.Pow(numfrank, numOrtiz)}");
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


