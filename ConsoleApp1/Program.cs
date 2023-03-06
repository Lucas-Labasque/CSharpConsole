using System.Security.Principal;
using System.Text;

class Program
{
    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = System.Text.Encoding.UTF8;
    //    Console.WriteLine("Entrer votre salaire : ");

    //    Console.WriteLine("Salaire : " + args[0]);
    //    Console.WriteLine("Taxe : " + args[1] + " %");
    //    Console.ReadLine();
    //}

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, je vais être capable de te doner ton salaire net annuel \n");
        Console.WriteLine("Entre ton salaire brut annuel : ");

        int salary;
        while (!int.TryParse(Console.ReadLine(), out salary))
        {
            Console.WriteLine("Erreur : Entrez une valeur valide en entier.");
        }

        Console.WriteLine("Super alors si ton salaire brut annuel est égal à : " + salary);

         
        Console.WriteLine("\nEntre ton taux de taxe : ");

        int tax;
        while (!int.TryParse(Console.ReadLine(),out tax))
        {
            Console.WriteLine("Erreur: Entrez une valeur valide en entier.");
        }

        Console.WriteLine("Super alors tu as pour taxe : " + tax);

        Console.WriteLine("\nVoici ton salaire net par mois : " + calcul(salary, tax));

        if (salary >= 50000)
        {
            Console.WriteLine("\nTu devrais faire des dons pour réduire des impots #rats");
        }
        if (salary <= 1500*12)
        {
            Console.WriteLine("\nLogique tu es un alternant");
        }
        if (salary > 30000 && salary < 40000)
        {
            Console.WriteLine("\nVient au CESI pour un bac+5 en dev ;)");
        }
        Console.ReadLine();
    }
    static int calcul(int salary, int tax)
    {
        return (salary * (1 - tax / 100)) / 12;
    }
}