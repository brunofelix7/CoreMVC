using System.ComponentModel.DataAnnotations;

namespace CoreMVC.Model.Model {

    public class Customer {

        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }

        public Customer() {

        }

        public Customer(int id, string name) {
            this.Id = id;
            this.Name = name;

        }
    }
}