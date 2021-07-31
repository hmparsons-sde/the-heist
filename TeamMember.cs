using System;
using System.Collections.Generic;
using System.Text;

namespace the_heist
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; private set; }
        public double CourageFactor { get; private set; } // only setting skill + courage in this class; a private setter keeps the value from being freely modified.

        public TeamMember()
        {
            Console.WriteLine("Enter team member's name");
            Name = Console.ReadLine();

            if (Name != "") // as long as a string is entered by user, do everything below. Otherwise move on to next part of the program.
            {
                Console.WriteLine($"Enter {Name}'s skill level");
                SkillLevel = int.Parse(Console.ReadLine()); // ignores any whitespace but expects an int

                do // using "do" iteration to conditionally execute the body at least once; as long as a team member name is entered.
                {
                    Console.WriteLine($"Enter {Name}'s courage factor, must be between 0 & 2");
                    CourageFactor = double.Parse(Console.ReadLine()); // expects a double (two decimal places)
                } while (CourageFactor < 0 || CourageFactor > 2); // while can execute 0 times. If nothing is entered, the "do" body will reprint.
            }
        }
    }
}
