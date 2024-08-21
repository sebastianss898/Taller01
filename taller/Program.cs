int select;

do
{
    Console.WriteLine("\n Pntos \n 1.Mayor de Tres Números \n 2.Contador de Vocales \n 3.Ordenamiento de Tres Números \n 4.Año Bisiesto \n 5.Generador de Números Aleatorios \n 6.Salir \n \n Seleccione una opcion :");
    select = Int32.Parse(Console.ReadLine());
    switch (select)
    {

        case 1:

            //-------------------- PUNTO 01---------------------
            Console.WriteLine("ingrese el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"numero :{num1}");

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"el numero mas grande es el : {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"el numero mas grande es el : {num2}");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"el numero mas grande es el : {num3}");
            }
            break;

        case 2:
            //------------------------- PUNTO 02------------------------------------------

            string texto;
            char[] cadena;
            int contador = 0;

            Console.WriteLine("ingrese su texto");
            texto = Console.ReadLine();


            cadena = texto.ToLower().ToCharArray();

            for (int i = 0; i < cadena.Length; i++)
            {

                if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u')
                {
                    contador++;
                }
            }

            Console.WriteLine($"la cantidad e vocales es : " + contador);

            break;

        case 3:
            //--------------------- PUNTO 03 -------------------------------------------------


            Console.WriteLine("ingrese el primer numero");
            int num01 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            int num02 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero");
            int num03 = int.Parse(Console.ReadLine());

            if (num01 > num02 && num01 > num03)
            {
                if (num02 > num03)
                {
                    Console.WriteLine($"el orden es :" + num03 + "-" + num02 + "-" + num01);
                }
                else
                {
                    Console.WriteLine($"el orden es :" + num02 + "-" + num03 + "-" + num01);
                }
            }
            else if (num02 > num01 && num02 > num03)
            {
                if (num01 > num03)
                {
                    Console.WriteLine($"el orden es :" + num03 + "-" + num01 + "-" + num02);
                }
                else
                {
                    Console.WriteLine($"el orden es :" + num01 + "-" + num03 + "-" + num02);
                }
            }
            else if (num03 > num01 && num03 > num02)
            {
                if (num01 > num02)
                {
                    Console.WriteLine($"el orden es :" + num02 + "-" + num01 + "-" + num03);
                }
                else
                {
                    Console.WriteLine($"el orden es :" + num01 + "-" + num02 + "-" + num03);
                }
            }

            break;

        case 4:
            //--------------------- PUNTO 04 -------------------------------------------------

            int ano1;
            int ano_actual = 2024;
            int contador1 = 0;

            Console.WriteLine("Ingrese el año de inicio");
            ano1 = Int32.Parse(Console.ReadLine());

            do
            {
                if ((ano1 % 4 == 0 && ano1 % 100 != 0) || (ano1 % 400 == 0))
                {
                    contador1++;
                }
                ano1++;
            } while (ano1 <= ano_actual);

            Console.WriteLine($"la cantidad e años Bisiestos son :" + contador1);

            break;
        case 5:
            //--------------------- PUNTO 05 -------------------------------------------------

            Random random = new Random();

            int alt = random.Next(1, 100);
            int dato = 0;
            // Console.WriteLine(alt);
            do
            {

                Console.WriteLine("ingrese su numero :");
                dato = Int32.Parse(Console.ReadLine());

                if (dato > alt)
                {
                    Console.WriteLine("el numero es menor");
                }
                else if (dato < alt)
                {
                    Console.WriteLine("el numero es mayor");
                }

            } while (dato != alt);

            Console.Write($"el numero fue encontrado :" + dato + " = " + alt);
            break;

    }

} while (select != 6);