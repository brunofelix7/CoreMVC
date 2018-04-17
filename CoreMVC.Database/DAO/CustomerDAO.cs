using System.Collections.Generic;
using System.Linq;
using CoreMVC.Database.DBContext;
using CoreMVC.Database.Interfaces;
using CoreMVC.Model.Model;

namespace CoreMVC.Database.DAO {

    public class CustomerDAO : ICustomerDAO, System.IDisposable {

        private readonly AppContext _context;
      
        public CustomerDAO(AppContext _context){
            this._context = _context;
        }

        public void Dispose() {
            this._context.Dispose();
        }

        public void Save(Customer customer) {
            this._context.Customers.Add(customer);
            this._context.SaveChanges();
        }

        public void Update(Customer customer) {
            this._context.Customers.Update(customer);
            this._context.SaveChanges();
        }
        
        public void Delete(Customer customer) {
            this._context.Customers.Remove(customer);
            this._context.SaveChanges();
        }

        public Customer FindOne(int id) {
            Customer customer = this._context.Customers.Find(id);
            return customer;
        }

        public IList<Customer> FindAll() {
            IList<Customer> customers = this._context.Customers.ToList();
            return customers;
        }
    }
}