namespace CoreMVC.Model.Model {

    public class Login {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Login() {

        }

        public Login(int id, string username, string password) {
            this.Id = id;
            this.Username = username;
            this.Password = password;

        }
    }
}