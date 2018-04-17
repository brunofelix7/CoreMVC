using System.Collections.Generic;
using CoreMVC.Model.Model;

namespace CoreMVC.Database.Interfaces {

    public interface ICustomerDAO {

        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        Customer FindOne(int id);
        IList<Customer> FindAll();
    }
}