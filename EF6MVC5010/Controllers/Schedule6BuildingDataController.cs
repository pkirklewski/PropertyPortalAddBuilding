using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EF6MVC5010.Models;

namespace EF6MVC5010.Controllers
{
    public class Schedule6BuildingDataController : Controller
    {
        private MobileFormsEntities db = new MobileFormsEntities();

        // GET: Schedule6BuildingData
        public ActionResult Index()
        {
            return View(db.Schedule6BuildingData.ToList());
        }

        // GET: Schedule6BuildingData/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule6BuildingData schedule6BuildingData = db.Schedule6BuildingData.Find(id);
            if (schedule6BuildingData == null)
            {
                return HttpNotFound();
            }
            return View(schedule6BuildingData);
        }

        // GET: Schedule6BuildingData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Schedule6BuildingData/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BuildingId,SiteId,TTSiteRef,Region,PropertyNo,BU,GOR,BuildingName,BuildingAddress1,BuildingAddress2,City,County,Postcode,ContractId,MajorOrMinor,ProposedVacantDate,BuildingMaintenance,BuildingManagement,EnergyAndUtilitiesManagement,LandscapeMaintenance,ExternalCleaning,WasteManagement,CateringFacilitiesAndEquipment,SecurityService,InternalCleaning,Porterage,SecurityEquipment,CustomerStewardingService,CateringService,EquipmentMaintenance,CommercialRef,CommercialRefExtra,CommercialRefExtra2,VOLogUpdate,AegisSite,AEGISLiveDate,ServicesConfirmed,SCHED6SRVSREQD,OriginalBaselineOperatingBand,CurrentOperatingBand,NormalWorkingHours,PublicOpeningHours")] Schedule6BuildingData schedule6BuildingData)
        {
            if (ModelState.IsValid)
            {
                db.Schedule6BuildingData.Add(schedule6BuildingData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(schedule6BuildingData);
        }

        // GET: Schedule6BuildingData/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule6BuildingData schedule6BuildingData = db.Schedule6BuildingData.Find(id);
            if (schedule6BuildingData == null)
            {
                return HttpNotFound();
            }
            return View(schedule6BuildingData);
        }

        // POST: Schedule6BuildingData/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BuildingId,SiteId,TTSiteRef,Region,PropertyNo,BU,GOR,BuildingName,BuildingAddress1,BuildingAddress2,City,County,Postcode,ContractId,MajorOrMinor,ProposedVacantDate,BuildingMaintenance,BuildingManagement,EnergyAndUtilitiesManagement,LandscapeMaintenance,ExternalCleaning,WasteManagement,CateringFacilitiesAndEquipment,SecurityService,InternalCleaning,Porterage,SecurityEquipment,CustomerStewardingService,CateringService,EquipmentMaintenance,CommercialRef,CommercialRefExtra,CommercialRefExtra2,VOLogUpdate,AegisSite,AEGISLiveDate,ServicesConfirmed,SCHED6SRVSREQD,OriginalBaselineOperatingBand,CurrentOperatingBand,NormalWorkingHours,PublicOpeningHours")] Schedule6BuildingData schedule6BuildingData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schedule6BuildingData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schedule6BuildingData);
        }

        // GET: Schedule6BuildingData/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule6BuildingData schedule6BuildingData = db.Schedule6BuildingData.Find(id);
            if (schedule6BuildingData == null)
            {
                return HttpNotFound();
            }
            return View(schedule6BuildingData);
        }

        // POST: Schedule6BuildingData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Schedule6BuildingData schedule6BuildingData = db.Schedule6BuildingData.Find(id);
            db.Schedule6BuildingData.Remove(schedule6BuildingData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
