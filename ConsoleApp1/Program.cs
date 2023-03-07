using System.Security.Principal;
using System.Text;
using ConsoleApp1.Modele;

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
        Users user = new Users();
        Console.WriteLine("Quel est votre ID : ");
        user.ID = int.Parse(Console.ReadLine());
        Console.WriteLine("Quel est votre Prénom : ");
        user.FirstName = Console.ReadLine();
        Console.WriteLine("Quel est votre Nom : ");
        user.LastName = Console.ReadLine();
        Console.WriteLine("Quel est votre Âge : ");
        user.Old = int.Parse(Console.ReadLine());
        Console.WriteLine("Quel est votre Salaire annuel Brut : ");
        user.Salary = int.Parse(Console.ReadLine().Replace("€", ""));
        Console.WriteLine("Quel est votre Taux d'imposition : ");
        user.Tax = int.Parse(Console.ReadLine().Replace("%", "")); Console.WriteLine("\nID : " + user.ID);



        Console.WriteLine("Prénom : " + user.FirstName);
        Console.WriteLine("Nom : " + user.LastName);
        Console.WriteLine("Âge : " + user.Old);
        Console.WriteLine("Salaire Brut : " + user.Salary + "€");
        Console.WriteLine("Taux d'imposition : " + user.Tax + "%");
        Console.WriteLine("Salaire Net : " + user.CalculateSalary() + "€");


        Console.OutputEncoding = Encoding.UTF8;

        // Tableau des mois
        string[] months = new string[13]
        {
        "", // Indice 0 inutilisé
        "Janvier", "Février", "Mars", "Avril", "Mai", "Juin",
        "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"
        };

        // Saisie du salaire mensuel
        Console.WriteLine("Entrez votre salaire mensuel : ");
        int salaryMensuel = 0;
        try
        {
            salaryMensuel = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("\nLa valeur que vous avez entrée n'est pas un nombre valide !");
            return;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("\nLa division par 0 n'est pas possible !");
            return;
        }

        // Calcul du salaire pour chaque mois
        foreach (string mois in months)
        {
            double salaireMensuelMois = salaryMensuel;
            switch (mois)
            {
                case "Août":
                    salaireMensuelMois = 0;
                    break;
                case "Décembre":
                    try
                    {
                        Console.WriteLine("Entrez le pourcentage de la prime de Noël : ");
                        int pourcentagePrimeNoel = int.Parse(Console.ReadLine());
                        salaireMensuelMois *= (1 + (pourcentagePrimeNoel / 100.0));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("La valeur que vous avez entrée n'est pas un nombre valide !");
                    }
                    break;
            }
            Console.WriteLine($"Salaire pour {mois} : {salaireMensuelMois} €");
        }

        //AUTRE EXO 


        Console.WriteLine("\n\n\nHello, je vais être capable de te donner ton salaire net mensuel \n");
        Console.WriteLine("Entre ton salaire brut annuel : ");

        int salary;
        while (!int.TryParse(Console.ReadLine(), out salary))
        {
            Console.WriteLine("Erreur : Entrez une valeur valide en entier.");
        }

        Console.WriteLine("Super alors si ton salaire brut annuel est égal à : " + salary + "€");


        Console.WriteLine("\nEntre ton taux de taxe : ");

        int tax;
        while (!int.TryParse(Console.ReadLine(), out tax))
        {
            Console.WriteLine("Erreur: Entrez une valeur valide en entier.");
        }

        Console.WriteLine("Super alors tu as pour taxe : " + tax + "%");

        double salaryNetPerMonth = salary / 12;

        Console.WriteLine("\nVoici ton salaire net par mois : " + salaryNetPerMonth + "€");
        
        switch (salary)
        {
            case >= 50000:
                Console.WriteLine("\nTu devrais faire des dons pour réduire des impots #rats");
                break;

            case <= 1500 * 12:
                Console.WriteLine("\nLogique tu es un alternant");
                break;

            case > 30000 :
                if (salary <
                    40000){
                    Console.WriteLine("\nVient au CESI pour un bac+5 en dev ;)");
                }
                break;
        }


        Console.ReadLine();
    }

}