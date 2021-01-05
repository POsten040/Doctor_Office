using Microsoft.AspNetCore.Mvc;
using Doctor_Office.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Doctor_Office.Controllers
{
  public class DoctorsController : Controller
  {
    private readonly Doctor_OfficeContext _db;
    public DoctorsController(Doctor_OfficeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Doctor> model = _db.Doctors.ToList();
      return View(_db.Doctors.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Doctor Doctor)
    {
      _db.Doctors.Add(Doctor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Doctor thisDoctor = _db.Doctors
        .Include(Doctor => Doctor.Patients)
        .ThenInclude(join => join.Patient)
        .FirstOrDefault(Doctor => Doctor.DoctorId == id);
      return View(thisDoctor);
    }

    public ActionResult Edit(int id)
    {
      var thisDoctor = _db.Doctors.FirstOrDefault(doctor => doctor.DoctorId == id);
      return View(thisDoctor);
    }

    [HttpPost]
    public ActionResult Edit(Doctor Doctor)
    {
      _db.Entry(Doctor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisDoctor = _db.Doctors.FirstOrDefault(doctor => doctor.DoctorId == id);
      return View(thisDoctor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisDoctor = _db.Doctors.FirstOrDefault(doctor => doctor.DoctorId == id);
      _db.Doctors.Remove(thisDoctor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}