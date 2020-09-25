using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulCustomerElephantService.Model
{
    public class Elephant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }

        // parameterless constructor
        public Elephant()
        {
            
        }

        // parametric constructor
        public Elephant(int id, string name, string species)
        {
            Id = id;
            Name = name;
            Species = species;
        }
    }
}
