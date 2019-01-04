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
//    public class SupplierController : Controller
//    {
//        private FMSExpEntities db = new FMSExpEntities();

//        // GET: Supplier
//        public async Task<ActionResult> Index()
//        {
//            return View(await db.tbl_Supplier.ToListAsync());
//        }

//        // GET: Supplier/Details/5
//        public async Task<ActionResult> Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            tbl_Supplier tbl_Supplier = await db.tbl_Supplier.FindAsync(id);
//            if (tbl_Supplier == null)
//            {
//                return HttpNotFound();
//            }
//            return View(tbl_Supplier);
//        }

//        // GET: Supplier/Create
//        public ActionResult Create()
//        {
//            ViewBag.ID = Helper.GenericHelper.GetMaxValue("tbl_Supplier");
//            ViewBag.CreatedDateTime = DateTime.Now;
//            return View();
//        }

//        // POST: Supplier/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> Create([Bind(Include = "ID,Name,ContactPerson,ContactNumber,Type,Place,GST_No,TIN_No,PAN_No,CIN_No,Address_Line1,Address_Line2,City,State,Pin_Code,PhoneNumber,Email,OpeningBalance,openingBalanceDate,CreditLimit,CreditPeriod,CreditIntrestRate,Remark,Photo,CreatedDateTime")] tbl_Supplier tbl_Supplier)
//        {
//            if (ModelState.IsValid)
//            {
//                db.tbl_Supplier.Add(tbl_Supplier);
//                await db.SaveChangesAsync();

//                tbl_Sequence NewSequenceValue = Helper.GenericHelper.GetNextUpdatedData("tbl_Supplier");
//                db.Entry(NewSequenceValue).State = EntityState.Modified;
//                await db.SaveChangesAsync();

//                return RedirectToAction("Index");
//            }

//            return View(tbl_Supplier);
//        }

//        // GET: Supplier/Edit/5
//        public async Task<ActionResult> Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            tbl_Supplier tbl_Supplier = await db.tbl_Supplier.FindAsync(id);
//            if (tbl_Supplier == null)
//            {
//                return HttpNotFound();
//            }
//            return View(tbl_Supplier);
//        }

//        // POST: Supplier/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> Edit([Bind(Include = "ID,Name,ContactPerson,ContactNumber,Type,Place,GST_No,TIN_No,PAN_No,CIN_No,Address_Line1,Address_Line2,City,State,Pin_Code,PhoneNumber,Email,OpeningBalance,openingBalanceDate,CreditLimit,CreditPeriod,CreditIntrestRate,Remark,Photo,CreatedDateTime")] tbl_Supplier tbl_Supplier)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(tbl_Supplier).State = EntityState.Modified;
//                await db.SaveChangesAsync();
//                return RedirectToAction("Index");
//            }
//            return View(tbl_Supplier);
//        }

//        // GET: Supplier/Delete/5
//        public async Task<ActionResult> Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            tbl_Supplier tbl_Supplier = await db.tbl_Supplier.FindAsync(id);
//            if (tbl_Supplier == null)
//            {
//                return HttpNotFound();
//            }
//            return View(tbl_Supplier);
//        }

//        // POST: Supplier/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> DeleteConfirmed(string id)
//        {
//            tbl_Supplier tbl_Supplier = await db.tbl_Supplier.FindAsync(id);
//            db.tbl_Supplier.Remove(tbl_Supplier);
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
