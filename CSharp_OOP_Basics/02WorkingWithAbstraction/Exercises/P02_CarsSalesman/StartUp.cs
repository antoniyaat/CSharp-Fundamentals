﻿using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var cars = new List<Car>();
        var engines = new List<Engine>();

        CreateEngines(engines);
        CreateCars(cars, engines);
        PrintCars(cars);
    }

    private static void PrintCars(List<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    private static void CreateCars(List<Car> cars, List<Engine> engines)
    {
        var carCount = int.Parse(Console.ReadLine());

        for (int index = 0; index < carCount; index++)
        {
            var parameters = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = parameters[0];
            var engineModel = parameters[1];
            var engine = engines.FirstOrDefault(x => x.Model == engineModel);

            if (parameters.Length == 3 && int.TryParse(parameters[2], out var weight))
            {
                cars.Add(new Car(model, engine, weight));
            }

            else if (parameters.Length == 3)
            {
                var color = parameters[2];
                cars.Add(new Car(model, engine, color));
            }

            else if (parameters.Length == 4)
            {
                var color = parameters[3];
                cars.Add(new Car(model, engine, int.Parse(parameters[2]), color));
            }

            else
            {
                cars.Add(new Car(model, engine));
            }
        }
    }

    private static void CreateEngines(List<Engine> engines)
    {
        var enginesCount = int.Parse(Console.ReadLine());

        for (int index = 0; index < enginesCount; index++)
        {
            var parameters = Console.ReadLine()
                ?.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = parameters[0];
            var power = int.Parse(parameters[1]);

            if (parameters.Length == 3 && int.TryParse(parameters[2], out var displacement))
            {
                engines.Add(new Engine(model, power, displacement));
            }

            else if (parameters.Length == 3)
            {
                var efficiency = parameters[2];
                engines.Add(new Engine(model, power, efficiency));
            }

            else if (parameters.Length == 4)
            {
                var efficiency = parameters[3];
                engines.Add(new Engine(model, power, int.Parse(parameters[2]), efficiency));
            }

            else
            {
                engines.Add(new Engine(model, power));
            }
        }
    }
}
