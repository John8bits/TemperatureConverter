using System.Security.Authentication;

namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("TEMPERATURE CONVERTER\n\n");
            Console.ResetColor();

            string ask;
            do
            {
                double temp;
            a:
                try
                {
                    Console.Write("Enter temperature value: ");
                    temp = double.Parse(Console.ReadLine());

                    if (temp <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Temperature value must not lesser than or equal to zero ");
                        Console.ResetColor();
                        goto a;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("String is not applicable\n");
                    Console.ResetColor();
                    goto a;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Empty input, Please enter again\n");
                    goto a;
                }

            u:
                Console.Write("\nEnter the current unit (Celsius, Fahrenheit, Kelvin): ");
                string unit = Console.ReadLine();

                if (unit.Equals("Celsius", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine();
                    int choice1;
                    Console.ForegroundColor= ConsoleColor.Green;
                     Console.WriteLine(" -----------------------------------");
                     Console.WriteLine("| Choose the unit to  convert to:   |");
                     Console.WriteLine("| 1.Fahrenheit                      |");
                     Console.WriteLine("| 2.Kelvin                          |");
                     Console.WriteLine(" -----------------------------------");
                     Console.ResetColor();

                c1:
                    try
                    {
                        Console.Write("Enter your choice: ");
                        choice1 = int.Parse(Console.ReadLine());

                        if (choice1 <= 0 && choice1 > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice (1 to 2 only). \n");
                            Console.ResetColor();
                            goto c1;
                        }

                        switch (choice1)
                        {
                            case 1:
                                Console.ForegroundColor= ConsoleColor.Green;
                                Console.WriteLine("\nConverted Temperature: {0:F2} °F", CelsiusToFahrenheit(temp));
                                Console.ResetColor();

                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Converted Temperature: {0:F2} °K", CelsiusToKelvin(temp));
                                Console.ResetColor();   
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid choice (1 to 2 only). ");
                                Console.ResetColor();
                                goto c1;

                        }

                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("String is not applicable, input number instead.\n");
                        Console.ResetColor();
                        goto c1;
                    }

                }
                else if (unit.Equals("Fahrenheit", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine();
                    int choice2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" -----------------------------------");
                    Console.WriteLine("| Choose the unit to  convert to:   |");
                    Console.WriteLine("| 1.Kelvin                          |");
                    Console.WriteLine("| 2.Celsius                         |");
                    Console.WriteLine(" -----------------------------------");
                    Console.ResetColor ();
                c2:
                    try
                    {
                        Console.Write("Enter your choice: ");
                        choice2 = int.Parse(Console.ReadLine());

                        if (choice2 <= 0 && choice2 > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice (1 to 2 only). \n");
                            Console.ResetColor();
                            goto c2;
                        }

                        switch (choice2)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nConverted Temperature: {0:F2} °C", FahrenheitToCelsius(temp));
                                Console.ResetColor();
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Converted Temperature: {0:F2} °K", FahrenheitKelvin(temp));
                                Console.ResetColor();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid choice (1 to 2 only). ");
                                Console.ResetColor();
                                goto c2;
                        }

                    }
                    catch (FormatException)
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("String is not applicable, input number instead.\n");
                        Console.ResetColor();
                        goto c2;
                    }

                }
                else if (unit.Equals("Kelvin", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine();
                    int choice3;
                    Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine(" -----------------------------------");
                     Console.WriteLine("| Choose the unit to  convert to:   |");
                     Console.WriteLine("| 1.Celsius                         |");
                     Console.WriteLine("| 2.Fahrenheit                      |");
                     Console.WriteLine(" -----------------------------------");
                     Console.ResetColor();
                c3:
                    try
                    {
                        Console.Write("Enter your choice: ");
                        choice3 = int.Parse(Console.ReadLine());

                        if (choice3 <= 0 && choice3 > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice (1 to 2 only). \n");
                            Console.ResetColor();
                            goto c3;
                        }

                        switch (choice3)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nConverted Temperature: {0:F2} °C", KelvinToCelsius(temp));
                                Console.ResetColor();
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Converted Temperature: {0:F2} °F", KelvinToFahrenheit(temp));
                                Console.ResetColor();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid choice (1 to 2 only).\n ");
                                Console.ResetColor();
                                goto c3;

                        }

                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("String is not applicable, input number instead.\n");
                        Console.ResetColor();
                        goto c3;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid unit! input only Fahrenheit,Celsius,Kelvin\n ");
                    Console.ResetColor();
                    goto u;
                }

                askagain:
                Console.Write("Do you want to convert another temperature (yes/no)? :  ");
                ask = Console.ReadLine();

                if (ask.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("\nProgram End.");
                    Console.ResetColor();
                    Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine("\n\n\n\t\t\t\t\tThankyou For Using My Program");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\t\t\t\t\t\t\t   - JBits");
                    Console.ResetColor();
                }
                else if (ask.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Invalid input! yes/no only.");
                    Console.ResetColor();
                    goto askagain;
                }


            } while (ask.Equals("Yes",StringComparison.InvariantCultureIgnoreCase));

       }


        static double CelsiusToFahrenheit(double celsius)
        {
           return (celsius * 9 / 5) + 32;
        }
        static double CelsiusToKelvin(double celsius)
        {   
            return celsius + 273.15;
        }

            static double FahrenheitToCelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }
            static double FahrenheitKelvin(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9 + 273.15;
            }

            static double KelvinToCelsius(double kelvin)
            {
                return kelvin - 273.15;
            }
            static double KelvinToFahrenheit(double kelvin)
            {
                return (kelvin - 273.15) * 9/5 + 32;
            }



        }
}
