
    class Ejercicio_Funciones
    {
        static void Main(string[] args)
        {
            // Cálculo del área de un círculo
            Console.WriteLine("1. Calcular el área de un círculo usando el radio");
            Console.WriteLine("Ingrese el radio");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.Round(AreaCirculo(radio), 2);
            Console.WriteLine("El área del círculo es: " + area);

            // Cálculo del perímetro de un rectánculo
            Console.WriteLine("\n2. Cálculo del perímetro de un rectánculo");
            Console.WriteLine("Ingrese la base");
            double Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            double Altura = double.Parse(Console.ReadLine());
            double perimetro = Math.Round(PerimetroRectangulo(Base, Altura), 2);
            Console.WriteLine("El perímetro es: " + perimetro);

            // Promedio de una lista de números enteros
            Console.WriteLine("\n3. Cálculo del promedio de la lista");
            List<int> lista = new List<int>() { 2, 5, 6, 12, 8, 9, 10, 11 };
            double promedio = Math.Round(ListaPromedio(lista), 2);
            Console.WriteLine("El promedio de la lista es: " + promedio);

            // Determinar si un número es par o impar
            Console.WriteLine("\n4.Determinar si un número es par o impar");
            Console.WriteLine("Ingrese un número entero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(ParoImpar(numero));

            // Convertir una cadena de texto a mayúscula
            Console.WriteLine("\n5.Convertir una cadena de texto a mayúscula");
            Console.WriteLine("Ingese su cadena de texto");
            string cadena = Console.ReadLine();
            string cadenaMaysc = PasaraMayuscula(cadena);
            Console.WriteLine("La cadena convertida es: " + cadenaMaysc);

            //Calcular la distancia entre dos puntos en el plano cartesiano
            Console.WriteLine("\n6.Calcular la distancia entre dos puntos en el plano cartesiano");
            int XA, YA, XB, YB;
            Console.WriteLine("Ingrese el punto xA");
            XA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el punto xB");
            XB = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el punto yA");
            YA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el punto yB");
            YB = int.Parse(Console.ReadLine());
            double distancia = DistanciaPuntos(XA, YA, XB, YB);
            Console.WriteLine("La distancia entre los puntos {0},{1} y {2},{3} es: {4}", XA, YA, XB, YB, Math.Round(distancia, 2));

            // Suma de los primeros número naturales
            Console.WriteLine("\n7.Ingrese su número natural: ");
            int num = int.Parse(Console.ReadLine());
            int suma = NumerosNaturales(num);
            Console.WriteLine("La suma de los primeros números naturales de {0} es: {1}", num, suma);

            // Calcular el factorial de un número
            Console.WriteLine("\n8.Determinar el factorial de un número: ");
            Console.WriteLine("Ingrese un número entero");
            int factorial = int.Parse(Console.ReadLine());
            int resultadoFactorial = NumeroFactorial(factorial);
            Console.WriteLine("El resultado del factorial de {0} es {1}", factorial, resultadoFactorial);
        }
        // Funcion del radio
        static double AreaCirculo(double radio)
        {
            double area = Math.PI * (radio * radio);
            return area;
        }
        // Funcion del perimetro
        static double PerimetroRectangulo(double Base, double Altura)
        {
            double perimetro = 2 * (Base + Altura);
            return perimetro;
        }
        // Funcion del promedio de la lista
        static double ListaPromedio(List<int> lista)
        {
            double promedio = lista.Average();
            return promedio;
        }
        // Funcion par o impar
        static bool ParoImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número {0} es par", numero);
            }
            else
            {
                Console.WriteLine("El número {0} es impar", numero);
            }
            return true;
        }
        // Funcion pasar a mayuscula
        static string PasaraMayuscula(string cadenaTexto)
        {
            return cadenaTexto.ToUpper();
        }
        // Funcion para calcular la distancia entre puntos
        static double DistanciaPuntos(int x1, int y1, int x2, int y2)
        {
            double distanciaPuntos = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distanciaPuntos;
        }

        // Funcion suma numeros naturales
        static int NumerosNaturales(int numero)
        {
            int suma = 0;
            for (int i = 0; i <= numero; i++)
            {
                suma += i;
            }
            return suma;
        }

        // Funcion del factorial
        static int NumeroFactorial(int numero)
        {
            int numFactorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                numFactorial *= i;
            }
            return numFactorial;
        }
    }