using System.Collections.Generic;
using System.Linq;
using CoreMVC.Database.DAO;
using CoreMVC.Database.DBContext;
using CoreMVC.Model.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoreMVC.Web.Controllers {

    public class CustomerController : Controller {

        private readonly CustomerDAO db;

        private ILogger<Customer> Log;

        public CustomerController(AppContext _context, ILogger<Customer> log) {
            this.db = new CustomerDAO(_context);
            this.Log = log;
        }

        [HttpGet]
        public IActionResult Index() {
            IList<Customer> customers = this.db.FindAll();
            ViewBag.Customers = customers;
            return View();
        }

        [HttpGet]
        public IActionResult Form() {
            var model = new Customer();
            return View(model);
        }

        [HttpPost]
        public IActionResult Form(Customer customer) {
            if (!ModelState.IsValid) {
                return View();
            }
            this.db.Save(customer);
            var message = $"Customer {customer.Name} added!";
            Log.LogInformation(message);
            TempData["Message"] = message;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id){
            Customer customer = this.db.FindOne(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer){
            if (!ModelState.IsValid) {
                return View();
            }
            this.db.Update(customer);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id){
            Customer customer = db.FindOne(id);
            this.db.Delete(customer);
            return RedirectToAction("Index");
        }
    }
}