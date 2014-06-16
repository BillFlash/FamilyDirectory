using data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyDirectory.web.Models
{
    public class AddEditVM
    {
        public Family Family        { get; set; }
        public Person Person        { get; set; }
        public string Title         { get; set; }
        public string ButtonMessage { get; set; }
    }
}