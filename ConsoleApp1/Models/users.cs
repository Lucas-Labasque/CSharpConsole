namespace ConsoleApp1.Modele
{

    // Définition de la classe User
    public class Users
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Old { get; set; }
        public int Salary { get; set; }
        public int Tax { get; set; }

        public double CalculateSalary()
        {
            return Salary * (1 - Tax / 100);
        }
    }
}


   