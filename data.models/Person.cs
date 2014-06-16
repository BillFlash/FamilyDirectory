using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.models
{
    public class Person
    {
        public int Id                       { get; set; }
        public virtual int FamilyId         { get; set; }
        public string FirstName             { get; set; }
        public string LastName              { get; set; }
        public string Birthday              { get; set; }
        public string Picture               { get; set; }
        public string Bio                   { get; set; }
        public virtual List<Family> Familes { get; set; } 
    }
}
