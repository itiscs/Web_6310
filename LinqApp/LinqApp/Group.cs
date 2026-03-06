using System;
using System.Collections.Generic;
using System.Text;

namespace LinqApp
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }

        public override string ToString()
        {
            return $"Group - {Id} {Name} {Faculty}";
        }
        public static List<Group> GetGroups()
        {
            var lst = new List<Group>()
            {
                new Group { Id = 1, Name = "6310", Faculty = "ВШПИТ" },
                new Group { Id = 2, Name = "6301", Faculty = "ВШПИТ" },
                new Group { Id = 3, Name = "2401", Faculty = "ФМФ" },
                new Group { Id = 4, Name = "2403", Faculty = "ФМФ" }

            };
            return lst;
        }
    }
}
