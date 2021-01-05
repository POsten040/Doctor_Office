using Microsoft.AspNetCore.Mvc;
using Doctor_Office.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Doctor_Office.Controllers
{
  public class SpecialtiesController : Controller
  {
    private readonly Doctor_OfficeContext _db;
    public SpecialtiesController(Doctor_OfficeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Specialty> model = _db.Specialties.ToList();
      return View(_db.Specialties.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Specialty Specialty)
    {
      _db.Specialties.Add(Specialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Specialty thisSpecialty = _db.Specialties
        .Include(Specialty => Specialty.Doctors)
        .ThenInclude(join => join.Doctor)
        .FirstOrDefault(Specialty => Specialty.SpecialtyId == id);
      return View(thisSpecialty);
    }

    public ActionResult Edit(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      return View(thisSpecialty);
    }

    [HttpPost]
    public ActionResult Edit(Specialty Specialty)
    {
      _db.Entry(Specialty).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      return View(thisSpecialty);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      _db.Specialties.Remove(thisSpecialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}