using System;
using System.Collections.Generic;
using System.Text;

namespace the_heist
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; private set; }
        public double CourageFactor { get; private set; }

        public TeamMember()
        {
            Console.WriteLine("Enter team member's name");
            Name = Console.ReadLine();

            if (Name != "")
            {
                Console.WriteLine($"Enter {Name}'s skill level");
                SkillLevel = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"Enter {Name}'s courage factor, must be between 0 & 2");
                    CourageFactor = double.Parse(Console.ReadLine());
                } while (CourageFactor < 0 || CourageFactor > 2);
            }
        }
    }
}
