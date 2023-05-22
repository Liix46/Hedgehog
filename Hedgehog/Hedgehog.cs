using System;
using System.Collections.Generic;

namespace Hedgehog
{
	public class Hedgehog
	{
        public static int Solve(int[] population, int desiredColor)
        {
            if (desiredColor < 0 || desiredColor >= 3)
            {
                throw new ArgumentOutOfRangeException(nameof(desiredColor));
            }

            if (population.Sum() == 0)
            {
                return 0;
            }


            int encounters = 0;

            var minColor = Int32.MaxValue;
            var maxColor = -1;

            var minColorIndex = -1;
            var maxColorIndex = -1;

            for (int i = 0; i < population.Length; i++)
            {
                if (i != desiredColor)
                {

                    if (population[i] > maxColor && i != minColorIndex)
                    {
                        maxColor = population[i];
                        maxColorIndex = i;
                    }

                    if (population[i] < minColor)
                    {
                        minColor = population[i];
                        minColorIndex = i;
                    }

                  
                }
            }

            while (true)
            {
                Console.WriteLine($"{population[0]}, {population[1]}, {population[2]}");
                if (population[minColorIndex] == population[maxColorIndex])
                {
                    if (population[minColorIndex] == 0)
                    {
                        return encounters;
                    }

                    population[minColorIndex]--;
                    population[maxColorIndex]--;
                    population[desiredColor] += 2;
                }
                else if (
                        population[minColorIndex] - population[maxColorIndex] == -1
                     || population[minColorIndex] - population[maxColorIndex] == 1)
                {
                    return -1;
                }
                else
                {
                    population[minColorIndex] += 2;
                    population[maxColorIndex]--;
                    population[desiredColor] --;
                }

                encounters++;
            }

        }

    }
}
