using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectDosApplication.Database;
using ProjectDosApplication.Models;
using ProjectDosApplication.Repository;

namespace ProjectDosApplication.Controllers
{
    public class HealthInsuranceMarketPlaceController : Controller
    {
        private CoverageDbContext db = new CoverageDbContext();
        private readonly IRecipientRepository _recipientRepository;
        private readonly IAddressRepository _addressRepository;

        public HealthInsuranceMarketPlaceController(IRecipientRepository recipientRepository, IAddressRepository addressRepository)
        {
            this._recipientRepository = recipientRepository;
            this._addressRepository = addressRepository;


            var addresss = new Address
            {

                Address1 = "Glen Raod",
                Address2 = "",
                City = "Charleston",
                ZipCode = "23345",
                State = "WV"
            };

            _addressRepository.Add(addresss);
            _addressRepository.Save();
        }

        // GET: HealthInsuranceMarketPlace
        public  ActionResult Index()
        {
            var a = _recipientRepository.GetAll().ToList();
            return View(a);
        }

        // GET: HealthInsuranceMarketPlace/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipient recipient = this._recipientRepository.GetRecipientById(id.Value);
            if (recipient == null)
            {
                return HttpNotFound();
            }
            return View(recipient);
        }

        // GET: HealthInsuranceMarketPlace/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HealthInsuranceMarketPlace/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MarketPlaceIdentifier,MarketPlaceAssignedPolicyNumber,PolicyIssuerName,RecipientFirstName,RecipientMiddleName,RecipientLastName,RecipientFirstSSN,RecipientDob,RecipientSpouseFirstName,RecipientSpouseMiddleName,RecipientSpouseLastName,RecipientSpouseSSN,RecipientSpouseDob,CreatedDate,CreatedBy,IsActiveRecord,DeactivatedDate,DeactivatedBy")] Recipient recipient)
        {
            if (ModelState.IsValid)
            {

                _recipientRepository.Add(recipient);
                _recipientRepository.Save();
                return RedirectToAction("Index");
            }

            return View(recipient);
        }

        // GET: HealthInsuranceMarketPlace/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipient recipient = this._recipientRepository.GetRecipientById(id.Value);
            if (recipient == null)
            {
                return HttpNotFound();
            }
            return View(recipient);
        }

        // POST: HealthInsuranceMarketPlace/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,MarketPlaceIdentifier,MarketPlaceAssignedPolicyNumber,PolicyIssuerName,RecipientFirstName,RecipientMiddleName,RecipientLastName,RecipientFirstSSN,RecipientDob,RecipientSpouseFirstName,RecipientSpouseMiddleName,RecipientSpouseLastName,RecipientSpouseSSN,RecipientSpouseDob,CreatedDate,CreatedBy,IsActiveRecord,DeactivatedDate,DeactivatedBy")] Recipient recipient)
        {
            if (ModelState.IsValid)
            {


                db.Entry(recipient).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(recipient);
        }

        // GET: HealthInsuranceMarketPlace/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipient recipient = _recipientRepository.GetRecipientById(id.Value);
 ;           if (recipient == null)
            {
                return HttpNotFound();
            }
            return View(recipient);
        }

        // POST: HealthInsuranceMarketPlace/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipient recipient = this._recipientRepository.GetRecipientById(id);
            this._recipientRepository.Delete(recipient);
            this._recipientRepository.Save();
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
