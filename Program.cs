int select;

do
{
    Console.WriteLine("Pntos \n 1.Mayor de Tres Números \n 2.Contador de Vocales \n 3.Ordenamiento de Tres Números \n 4.Año Bisiesto \n 5.Generador de Números Aleatorios \n 6.Salir \n \n Seleccione una opcion :");
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

            string txt;
            char[] charVector;
            int charCounter = 0;

            Console.WriteLine("ingrese su texto");
            txt = Console.ReadLine();


            charVector = txt.ToLower().ToCharArray();

            for (int i = 0; i < charVector.Length; i++)
            {

                if (charVector[i] == 'a' || charVector[i] == 'e' || charVector[i] == 'i' || charVector[i] == 'o' || charVector[i] == 'u')
                {
                    charCounter++;
                }
            }

            Console.WriteLine($"la cantidad e vocales es : " + charCounter);

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
                    Console.WriteLine($"el orden es :{num03}-{num02}-{num01}");
                }
                else
                {
                    Console.WriteLine($"el orden es :{num02}-{num03}-{num01}");
                }
            }
            else if (num02 > num01 && num02 > num03)
            {
                if (num01 > num03)
                {
                    Console.WriteLine($"el orden es :{num03}-{num01}-{num02}");
                }
                else
                {
                    Console.WriteLine($"el orden es :{num01}-{num03}-{num02}");
                }
            }
            else if (num03 > num01 && num03 > num02)
            {
                if (num01 > num02)
                {
                    Console.WriteLine($"el orden es :{num02}-{num01}-{num03}");
                }
                else
                {
                    Console.WriteLine($"el orden es :{num01}-{num02}-{num03}");
                }
            }

            break;

        case 4:
            //--------------------- PUNTO 04 -------------------------------------------------

            int initYear;
            int currentYear = 2024;
            int counterYears = 0;

            Console.WriteLine("Ingrese el año de inicio");
            initYear = Int32.Parse(Console.ReadLine());

            do
            {
                if ((initYear % 4 == 0 && initYear % 100 != 0) || (initYear % 400 == 0))
                {
                    counterYears++;
                }
                initYear++;
            } while (initYear <= currentYear);

            Console.WriteLine($"la cantidad e años Bisiestos son :{counterYears}");

            break;
        case 5:
            //--------------------- PUNTO 05 -------------------------------------------------

            Random random = new Random();

            int numRandom = random.Next(1, 100);
            int numJoined = 0;
            // Console.WriteLine(numRandom);
            do
            {

                Console.WriteLine("ingrese su numero :");
                numJoined = Int32.Parse(Console.ReadLine());

                if (numJoined > numRandom)
                {
                    Console.WriteLine("el numero es menor");
                }
                else if (numJoined < numRandom)
                {
                    Console.WriteLine("el numero es mayor");
                }

            } while (numJoined != numRandom);

            Console.Write($"el numero fue encontrado :{numJoined} = {numRandom} \n");
            break;

    }

} while (select != 6);