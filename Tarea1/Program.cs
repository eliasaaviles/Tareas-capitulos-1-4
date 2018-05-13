using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea1
{
    
    static class Constantes
    {
        public const double Pi = 3.1416;
        public const double fa = 1.8000;
    }
    class Program
    {
        static void Main()
        {

            int opcion = 0;
            string op = "";

            for (; ; )
            {
                Console.WriteLine("Elias Alejandro, 2014-0657");
                Console.WriteLine(
               "\n" + "1- Ejercicio 1.1" +
                "\n" + "2- Ejercicio 1.5" +
                "\n" + "3- Ejercicio 2.1" +
                "\n" + "4- Ejercicio 2.3" +
                "\n" + "5- Ejercicio 2.4" +
                "\n" + "6- Ejercicio 2.5" +
                "\n" + "7- Ejercicio 3.1" +
                "\n" + "8- Ejercicio 3.4" +
                "\n" + "9- Ejercicio 3.5" +
                "\n" + "10- Ejercicio 4.1" +
                "\n" + "11- Ejercicio 4.2" +
                "\n" + "12- Ejercicio 4.5" + "\n");

                Console.Write("Seleccione una Opcion, por favor:");

                op = Console.ReadLine();
                opcion = Convert.ToInt32(op);



                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n" + "Elias Alejandro Aviles Guzman");
                        break;
                    case 2:
                        Console.WriteLine(" \n" + " Soy Elias Alejandro Aviles Guzman" + "\n" +
                            " Estudio Ingenieria en sistemas" + "\n" +
                            " Mi Matricula es: " + "2014-0657");
                        break;
                    case 3:
                        String lado = " ";
                        int resultado,longitud,lados;
                        Console.Write("\n" + "Digite cantidad de lados ");
                        lado = Console.ReadLine();
                        lados = Convert.ToInt32(lado);
                        
                        Console.Write("\n" + "Digite la longitud ");
                        lado = Console.ReadLine();
                        longitud = Convert.ToInt32(lado);


                        resultado = lados * longitud;


                        Console.WriteLine("\n" + "El Resultado es: {0}", resultado);
                        break;

                    case 4:
                        String grado = " ";
                        double grados = 0, radianes = 0;
                        Console.WriteLine("Digite los Grados a convertir: ");
                        grado = Console.ReadLine();
                        grados = Convert.ToDouble(grado);

                        radianes = (grados * Constantes.Pi) / 180;


                        Console.WriteLine("\n" + "El Resultado es: {0}", radianes + " Radianes");
                        break;

                    case 5:
                        String gradoc = " ";
                        double gradosc = 0, farenheit = 0;
                        Console.WriteLine("Digite los Grados a convertir: ");
                        gradoc = Console.ReadLine();
                        gradosc = Convert.ToDouble(gradoc);

                        farenheit = (gradosc * Constantes.fa) + 32;

                        Console.WriteLine("\n" + "El Resultado es: {0}", farenheit + " Farenheit");
                        break;

                    case 6:
                        String cambio = " ";
                        double dolar = 0, euro = 0, tasa;
                        Console.WriteLine("Digite la tasa del euro del dia: ");
                        cambio = Console.ReadLine();
                        tasa = Convert.ToDouble(cambio);

                        Console.WriteLine("Digite los el monto en dolar a cambiar: ");
                        cambio = Console.ReadLine();
                        dolar = Convert.ToDouble(cambio);

                        euro = dolar / tasa;

                        Console.WriteLine("\n" + "El su cambio es: {0}", euro + " $$  Euros");
                        break;

                    case 7:
                        String valor = " ";
                        double num = 0;

                        Console.WriteLine("Digite un numero: ");
                        valor = Console.ReadLine();
                        num = Convert.ToDouble(valor);

                        if ((num % 2) == 0)
                            Console.WriteLine("Es Par");
                        else
                            Console.WriteLine("Es Impar");

                        break;

                    case 8:

                        String dias = " ";
                        double dia = 0;

                        Console.WriteLine("Digite un numero del 1-7: ");
                        dias = Console.ReadLine();
                        dia = Convert.ToDouble(dias);

                        switch (dia)
                        {
                            case 1:
                                Console.WriteLine("\n" + "Domingo");
                                break;
                            case 2:
                                Console.WriteLine("\n" + "Lunes");
                                break;
                            case 3:
                                Console.WriteLine("\n" + "Martes");
                                break;
                            case 4:
                                Console.WriteLine("\n" + "Miercoles");
                                break;
                            case 5:
                                Console.WriteLine("\n" + "Jueves");
                                break;
                            case 6:
                                Console.WriteLine("\n" + "Viernes");
                                break;
                            case 7:
                                Console.WriteLine("\n" + "Sabado");
                                break;
                            default:
                                Console.WriteLine("\n" + "No existe!");
                                break;
                        }
                        break;

                    case 9:

                        String lad = " ",opc=" ";
                        double longi,ladoss,opt,area, perimetro;

                        Console.WriteLine("Digite la longitud: ");
                        lad = Console.ReadLine();
                        longi = Convert.ToDouble(lad);

                        Console.WriteLine("Digite la cantidad de lados: ");
                        lad = Console.ReadLine();
                        ladoss = Convert.ToDouble(lad);

                        Console.WriteLine("digite una opcion: 1- AREA   2- PERIMETRO  3-AMBOS:  ");
                        opc = Console.ReadLine();
                        opt = Convert.ToDouble(opc);

                        switch (opt)
                        {
                            case 1:
                                perimetro = longi * ladoss;
                                Console.WriteLine("El perimetro es: {0}",perimetro);
                                break;
                            case 2:
                               area =  Math.Pow(longi, ladoss);
                               Console.WriteLine("El perimetro es: {0}", area);
                                break;
                            case 3:
                                perimetro = longi * ladoss;
                               area = Math.Pow(longi, ladoss);
                                Console.WriteLine("El perimetro es: {0} y el area es: {1}", perimetro,area);
                                break;
                            default:
                                Console.WriteLine("\n" + "opcion no valida");
                                break;
                        }
                        break;

                    case 10:
                        {
                            String tabla = "";
                            int numero;
                            Console.WriteLine("Digite el numero que desee: ");
                            tabla = Console.ReadLine ();
                            numero = Convert.ToInt32(tabla);

                            for(int i=0; i < 13;i++)
                            {
                                Console.WriteLine(i + " X " + numero + " = " + numero * i);
                            }
                            Console.ReadKey();
                            break;


                        }
                    case 11:
                        {
                            String N = "";
                            int numero,potencia;
                            Console.WriteLine("Digite el numero que desea elevar: ");
                            N = Console.ReadLine();
                            numero = Convert.ToInt32(N);

                            Console.WriteLine("Digite la potencia: ");
                            N = Console.ReadLine();
                            potencia = Convert.ToInt32(N);

                            resultado = 1;

                            for (int x = 0; x < potencia; x++)
                            {
                                resultado *= numero;
                            }

                            Console.WriteLine("El resultado es: {0}",resultado);
                            break;

                           }
                    case 12:
                        {
                            String p = "";
                            Double promedio;
                            int persona, edad, mayor=0, menor=0,acum=0;

                            Console.WriteLine("Digite la cantidad de personas: ");
                            p = Console.ReadLine();
                            persona = Convert.ToInt32(p);

                            for(int l=0; l < persona; l++)
                            {
                                Console.WriteLine("Digite la edad de la persona: ");
                                p = Console.ReadLine();
                                edad = Convert.ToInt32(p);

                                if (edad>mayor)
                                {
                                    mayor = edad;
                                }

                                else
                                {
                                    menor = edad;
                                }
                                acum += edad;


                            }

                            promedio = acum / persona;

                            Console.WriteLine("El promedio es: {0}",promedio);
                            Console.WriteLine("El mayor es: {0} Y el menor es: {1}", mayor,menor);
                            break;

                        }
                }

                Console.ReadKey();
                Console.Clear();

            }


        }
    }
}

