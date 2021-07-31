using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_heist
{
    class Heist
    {
        public int BankDifficulty { get; private set; } 
        private int _luckValue { get; set; } // luck value will remain hidden from user.

        public Heist()
        {
            Console.WriteLine("Enter the difficulty of the bank as an integer");
            BankDifficulty = int.Parse(Console.ReadLine());

            var crew = new Crew();

            Console.WriteLine("Enter the number of times to run the scenario");

            var trials = int.Parse(Console.ReadLine());
            var successes = 0;
            var failures = 0;
            for (var i = 0; i < trials; i++)
            {
                Random r = new Random();
                _luckValue = r.Next(-10, 10); // returns a random integer in this range
                var adjustedDifficulty = BankDifficulty + _luckValue;
                if (crew.CumulativeSkill < adjustedDifficulty)
                {
                    failures++;
                }
                else
                {
                    successes++;
                }
            }
            Console.WriteLine($"{crew.Name} successfully heisted {successes} out of {trials} runs and failed {failures} out of {trials} runs");
        }
    }
}