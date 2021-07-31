using System;
using System.Collections.Generic;
using System.Text;

namespace the_heist
{
    class Crew
    {
        public string Name { get; set; }
        public List<TeamMember> CrewMembers { get; private set; } = new List<TeamMember>();
        public int CumulativeSkill { get; private set; }

        public Crew()
        {

            Console.WriteLine("What is the name of your crew?");
            Name = Console.ReadLine();

            var run = true;
            while (run)
            {
                var x = new TeamMember();
                if (x.Name == "") break;
                CrewMembers.Add(x);
                if (CrewMembers.Count == 1)
                {
                    Console.WriteLine($"There is now 1 member in {Name}.");
                }
                else
                {
                    Console.WriteLine($"There are now {CrewMembers.Count} members in {Name}.");
                }
            }

            var cumulativeSkill = 0;
            CrewMembers.ForEach((member) => cumulativeSkill += member.SkillLevel);
            CumulativeSkill = cumulativeSkill;
        }
    }
}