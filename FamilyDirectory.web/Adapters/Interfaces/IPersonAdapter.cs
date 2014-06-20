using data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyDirectory.web.Adapters.Interfaces
{
    public interface IPersonAdapter
    {
        List<Person> GetListPerson();
        List<Family> GetListFamily();
        Person GetPerson(int id);
        Person GetPersonByName(string person);//I might be duplicating what is above?
        void AddPerson(Person Person);
        void DeletePerson(int id);
        void EditPerson(Person Person);
        void AddFamily(Family Family);
        void EditFamily(Family Family);
        void DeleteFamily(int id);  
    }
}
