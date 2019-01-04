//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using FMS;

//namespace FMS.Controllers
//{
//    public class CustomerController : Controller
//    {
//        private FMSExpEntities db = new FMSExpEntities();

//        // GET: Customer
//        public async Task<ActionResult> Index()
//        {
//            return View(await db.tbl_Customer.ToListAsync());
//        }

//        // GET: Customer/Details/5
//        public async Task<ActionResult> Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            tbl_Customer tbl_Customer = await db.tbl_Customer.FindAsync(id);
//            if (tbl_Customer == null)
//            {
//                return HttpNotFound();
//            }
//            return View(tbl_Customer);
//        }

//        // GET: Customer/Create
//        public ActionResult Create()
//        {
//            ViewBag.CustomerID = Helper.GenericHelper.GetMaxValue("tbl_Customer");
//            ViewBag.CreatedDatetime = DateTime.Now;
//            return View();
//        }

//        // POST: Customer/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> Create([Bind(Include = "AutoID,CustomerID,Name,ContactPerson,CustomerType,DOB,Place,GSTNo,TINNo,PanNo,AdharNumber,CINNumber,OpeningBalance,OpeningBalanceType,BalanceOpeningDate,CreditLimit,CreditPeriod,CreditInterest,Debitinterest,SuretyPerson,SuretyPersonContactNumber,Address,Photo,CreatedDatetime,MobileNumber")] tbl_Customer tbl_Customer)
//        {
//            if (ModelState.IsValid)
//            {
//                db.tbl_Customer.Add(tbl_Customer);
//                await db.SaveChangesAsync();
//                return RedirectToAction("Index");
//            }

//            return View(tbl_Customer);
//        }

//        // GET: Customer/Edit/5
//        public async Task<ActionResult> Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            tbl_Customer tbl_Customer = await db.tbl_Customer.FindAsync(id);
//            if (tbl_Customer == null)
//            {
//                return HttpNotFound();
//            }
//            return View(tbl_Customer);
//        }

//        // POST: Customer/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> Edit([Bind(Include = "AutoID,CustomerID,Name,ContactPerson,CustomerType,DOB,Place,GSTNo,TINNo,PanNo,AdharNumber,CINNumber,OpeningBalance,OpeningBalanceType,BalanceOpeningDate,CreditLimit,CreditPeriod,CreditInterest,Debitinterest,SuretyPerson,SuretyPersonContactNumber,Address,Photo,CreatedDatetime,MobileNumber")] tbl_Customer tbl_Customer)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(tbl_Customer).State = EntityState.Modified;
//                await db.SaveChangesAsync();
//                return RedirectToAction("Index");
//            }
//            return View(tbl_Customer);
//        }

//        // GET: Customer/Delete/5
//        public async Task<ActionResult> Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            tbl_Customer tbl_Customer = await db.tbl_Customer.FindAsync(id);
//            if (tbl_Customer == null)
//            {
//                return HttpNotFound();
//            }
//            return View(tbl_Customer);
//        }

//        // POST: Customer/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> DeleteConfirmed(string id)
//        {
//            tbl_Customer tbl_Customer = await db.tbl_Customer.FindAsync(id);
//            db.tbl_Customer.Remove(tbl_Customer);
//            await db.SaveChangesAsync();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
