using System;

    namespace weather_identifier
{
    class program
    {
        static void Main(string[] args)
        {
            //loop
            string type = "";
            while (type != "Celcius" && type != "celcius" && type != "Farenheit" && type != "farenheit" && type != "Kelvin" && type != "kelvin")
            {
                Console.WriteLine("What type of temperature do you want? (Celcius, Farenheit, Kelvin)");
                type = Console.ReadLine();

                //celcius
                if (type == "Celcius" || type == "celcius")
                {
                    Console.WriteLine("What is the temperature right now? (Celcius)");
                    double temperaturec = Convert.ToDouble(Console.ReadLine());

                    if (temperaturec <= 10)
                    {
                        Console.WriteLine("it is not advisable to go out, it's freezing cold outsude");
                    }
                    else if (temperaturec <= 20)
                    {
                        Console.WriteLine("You can go outside but wear thick clothing, it's chilly outside");
                    }
                    else if (temperaturec <= 30)
                    {
                        Console.WriteLine("Wear sunscreen, it's hot outside");
                    }
                    else
                    {
                        Console.WriteLine("It is also not advisable to go outside, it's burning outside");
                    }
                }

                //farenheit
                else if (type == "Farenheit" || type == "farenheit")
                {
                    Console.WriteLine("What is the temperature right now? (Farenheit)");
                    double temperaturef = Convert.ToDouble(Console.ReadLine());

                    if (temperaturef <= 50)
                    {
                        Console.WriteLine("it is not advisable to go out, it's freezing cold outsude");
                    }
                    else if (temperaturef <= 68)
                    {
                        Console.WriteLine("You can go outside but wear thick clothing, it's chilly outside");
                    }
                    else if (temperaturef <= 86)
                    {
                        Console.WriteLine("Wear sunscreen, it's hot outside");
                    }
                    else
                    {
                        Console.WriteLine("It is also not advisable to go outside, it's burning outside");
                    }
                }

                //kelvin
                else if (type == "Kelvin" || type == "kelvin")
                {
                    Console.WriteLine("What is the temperature right now? (Kelvin)");
                    double temperaturek = Convert.ToDouble(Console.ReadLine());

                    if (temperaturek <= 283.15)
                    {
                        Console.WriteLine("it is not advisable to go out, it's freezing cold outsude");
                    }
                    else if (temperaturek <= 293.15)
                    {
                        Console.WriteLine("You can go outside but wear thick clothing, it's chilly outside");
                    }
                    else if (temperaturek <= 303.15)
                    {
                        Console.WriteLine("Wear sunscreen, it's hot outside");
                    }
                    else
                    {
                        Console.WriteLine("It is also not advisable to go outside, it's burning outside");
                    }
                }

                else
                {
                    Console.WriteLine("Please input a valid type of temperature.");
                }
            }
        }
    }
}