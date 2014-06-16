using data;
using data.models;
using FamilyDirectory.web.Adapters.DataAdapaters;
using FamilyDirectory.web.Adapters.Interfaces;
using FamilyDirectory.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FamilyDirectory.web.Controllers
{
    public class HomeController : Controller
    {
         private IPersonAdapter _adapter;
         public HomeController(IPersonAdapter adapter)
         {
             _adapter = adapter;

         }
         public HomeController()
         {
             _adapter = new PersonDataAdapter();
         }
         public ActionResult Index()
         {
             List<Person> people = _adapter.GetListPerson();
             return View(people);
         }
         public ActionResult People()//Just use the index instead???
         {
             var model = _adapter.GetListPerson();
             return View(model);
         }
         public ActionResult Family()
         {
             var model = _adapter.GetListFamily();
             return View(model);
         }
         [HttpGet]
         public ActionResult AddPerson()
         {
             AddEditVM model = new AddEditVM();
             model.Title = "Add your a family member";
             model.ButtonMessage = "Add";
             return View(model);
         }
         [HttpPost]
         public ActionResult AddPerson(Person person)
         {
             using (ApplicationDbContext db = new ApplicationDbContext())
             {
                 db.People.Add(person);
                 db.SaveChanges();
             }
             return RedirectToAction("Index");
         }
         [HttpGet]
         public ActionResult EditPerson(int id)
         {
             AddEditVM model = new AddEditVM();
             model.Person = _adapter.GetPerson(id);
             model.Title = "Edit Pet" + model.Person.FirstName;
             model.ButtonMessage = "Submit Changes";
             return View("AddPerson", model);
         }
         [HttpPost]
         public ActionResult EditPerson(Person person)
         {
             _adapter.EditPerson(person);

             return RedirectToAction("Person", new { id = person.Id });
         }
         [HttpGet]
         public ActionResult DeletePerson(int Id)
         {
             _adapter.DeletePerson(Id);
             return RedirectToAction("Index");
         }
         [HttpGet]
         public ActionResult AddFamily()
         {
             AddEditVM model = new AddEditVM();
             model.Title = "Add your Family!";
             model.ButtonMessage = "Add";
             return View(model);
         }
         [HttpPost]
         public ActionResult AddFamily(Family family)
         {
             using (ApplicationDbContext db = new ApplicationDbContext())
             {
                 db.Families.Add(family);
                 db.SaveChanges();
             }
             return RedirectToAction("Family");
         }
         [HttpGet]
         public ActionResult DeleteFamily(int Id)
         {
             _adapter.DeleteFamily(Id);
             return RedirectToAction("Family");
         }
         [HttpGet]
         public ActionResult PersonDetail(int Id)
         {
            Person person = _adapter.GetPerson(Id);
             return View(person);
         }
         public ActionResult FamilyDetails()
         {
             return View();
         }
    }
}