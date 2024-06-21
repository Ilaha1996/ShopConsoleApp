namespace Shop.Core.Models
{
    public class Employee:Base
    {
        private string _name;
        private string _surname;
        private double _salary;
        private string _roleType;
        private string _username;
        private string _pasword;

        private static int _counter;
        public string Name { get; set; }    
        public string Surname { get; set; }
        public double Salary 
        { get { return Salary; }

            set 
            {
                if (_salary!>= double.MinValue)
                {
                    throw new ArgumentException();

                }
                Salary = value; 
            }
        }
        public string RoleType 
        {
            get
            { return RoleType; }

            set
            {
                if (_roleType!= "Admin" || _roleType!= "Worker")                 
                {
                    throw new ArgumentException();
                }
                
                RoleType = value;
            }
        
        }
        public string Username
        {
            get
            { return Username; }

            set
            { Username = value; }

        }
        public string Password { get; set; }

        public Employee(string name, string surname, string roleType, string username, string password, double salary)
        {
            Id = ++_counter;
            _name = name;
            _surname = surname;
            _roleType = roleType;
            _username = username;
            _pasword= password;
            _salary = salary;
            
        }
        
    }
}
