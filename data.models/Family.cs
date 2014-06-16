using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.models
{
    public class Family
    {
        public int Id                               { get; set; }
        public int PersonId                         { get; set; }
        public string NameOfFamily                  { get; set; }
        public string FamilyCrest                   { get; set; }
        public virtual List <Person> People         { get; set; }
    }
}
