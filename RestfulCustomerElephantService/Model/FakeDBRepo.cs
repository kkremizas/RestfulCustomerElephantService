using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulCustomerElephantService.Model
{
    public class FakeDBRepo
    {
        public static List<Elephant> elps = new List<Elephant>()
        {
            new Elephant(1, "Pomi", "African"),
            new Elephant(2, "Lily", "Asian"),
            new Elephant(3, "Tony", "South-African"),
            new Elephant(4, "Loly", "North-American"),
            new Elephant(5, "Nony", "South-American")
        };

    }
}
