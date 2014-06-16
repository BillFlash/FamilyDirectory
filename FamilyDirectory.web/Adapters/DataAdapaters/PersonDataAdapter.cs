using data;
using data.models;
using FamilyDirectory.web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyDirectory.web.Adapters.DataAdapaters
{
    public class PersonDataAdapter : IPersonAdapter
    {
        public List<Person> GetListPerson()
        {
            List<Person> model = new List<Person>();
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.People.ToList();
            }
            return model;
        }
        public List<Family> GetListFamily()
        {
            List<Family> model = new List<Family>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Families.ToList();
            }
            return model;
        }

        public Person GetPerson(int id)
        {
            Person person = new Person();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                person = db.People.Where(x => x.Id == id).FirstOrDefault();
            }
            return person;
        }
        public void DeletePerson(int Id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Person person = db.People.Find(Id);
                db.People.Remove(person);
                db.SaveChanges();
            }
        }
        public void EditPerson(Person person)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Person model = db.People.Find(person.Id);
                model.FirstName = person.FirstName;
                model.Picture = person.Picture;
                db.SaveChanges();
            }
        }
        public void AddFamily(Family family)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Families.Add(family);
                var sentback = db.SaveChanges();
            }
        }
        public void DeleteFamily(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Family family = db.Families.Find(id);
                db.Families.Remove(family);
                db.SaveChanges();
            }
        }
        public Person GetPersonByName(string person)
        {
            Person model;
            using(ApplicationDbContext db = new ApplicationDbContext())
           {
                model = db.People.Include("People").Where(p => p.FirstName == person).FirstOrDefault();
            };
            return model;
        }

        public void AddPerson(Person person)
        {
           using(ApplicationDbContext db = new ApplicationDbContext())
           {
               db.People.Add(person);
               var sentback = db.SaveChanges();
           }
        }
        public void EditFamily(Family family)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Family model = db.Families.Find(family.Id);
                model.NameOfFamily = family.NameOfFamily;
                model.FamilyCrest = family.FamilyCrest;
                db.SaveChanges();
            }
        }
    }
}