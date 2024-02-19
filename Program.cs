#region calcul_age
int jour, mois, annee;
Console.WriteLine("Veuillez entrer votre date de naissance pour connaitre votre âge actuel");
Console.WriteLine();
Console.WriteLine("jour");
jour = int.Parse(Console.ReadLine());

Console.WriteLine("mois");
mois = int.Parse(Console.ReadLine());

Console.WriteLine("année");
annee = int.Parse(Console.ReadLine());

DateTime DateActu = DateTime.Now;

DateTime DateNaissance = new DateTime(annee, mois, jour);

int age = DateActu.Year -  DateNaissance.Year;

if (DateActu.Month - DateNaissance.Month < 12) { age -= 1; }
Console.WriteLine($"Vous avez {age}");
#endregion