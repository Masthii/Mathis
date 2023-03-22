using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_lourds
{
    class Program
    {
        static void Code()
        {
            int x = 3;
            Console.WriteLine("Veillez entrer votre code  de carte bleu à 4 chiffre suivie de la touche ENTER ! Vous avez " + x + " tentatives !");
            string code = Console.ReadLine();
            string mdp = "7150";
            if (mdp == code)
            {
                Console.WriteLine("Paiement confirmer !");
                Menu();
            }
            else
            {
                int i = 0;
                int tentative = 3;
                while (i <= 2)
                {
                    tentative--;
                    Console.WriteLine("Code incorecte ! Veuillez resaisir votre code,\n Il vous reste " + tentative + " tentatives !");
                    i++;
                    code = Console.ReadLine();


                    if (code == mdp)
                    {
                        i = i + 4;
                        Console.WriteLine("Paiement confirmer !");
                        Menu();
                    }
                    if (i == 2)
                    {
                        Console.WriteLine("Code erronnée , votre compte est bloqué, merci de contacter votre banque!");
                        Environment.Exit(0);
                    }
                }
            }
        }
        static void Menu()
        {
            int réponse;
            do
            {
                Console.WriteLine("Veuillez sélectionner une option grace au chiffre attribué :\n 1 Acheter un ticket de loto\n 2 Historique\n 3 Consulter le tirage\n 4 Exit");
                réponse = Convert.ToInt32(Console.ReadLine());
                /*Début du tirage de Ticket*/
                if (réponse == 1)
                {
                    Console.WriteLine("Voulez-vous :\n 1 Grille Flash\n 2 Grille normal");
                    int réponse2 = Convert.ToInt32(Console.ReadLine());
                    /*Début du tirage de Ticket Flash*/
                    if (réponse2 == 1)
                    {
                        Console.WriteLine("Nombre de ticket souhété");
                        int nbtic = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            int n = 5;
                            int[] m = new int[n];
                            Random a = new Random();
                            for (int i = 0; i < m.Length; i++)
                            {
                                m[i] = a.Next(1, 51);
                            }
                            foreach (int i in m)
                            {
                                Console.Write(i + " ");
                            }
                            Console.Write("\n");

                            nbtic--;
                        } while (nbtic != 0);
                        Code();
                    }
                    /*Fin du tirage de Ticket Flash*/
                    /*Début du tirage de Ticket normal*/
                    else if (réponse2 == 2)
                    {
                        Console.WriteLine("Nombre de ticket souhété");
                        int nbtic = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Tu dois Choisir 5 nombre entre 1 et 50 compris");
                            int[] tab = new int[5];
                            for (int i = 0; i < tab.Length; i++)
                            {
                                Console.WriteLine("Choisie un nombre entre 1 et 50 compris");
                                int ticket = Convert.ToInt32(Console.ReadLine());
                                if (ticket <= 50 & ticket >= 1)
                                {
                                    tab[i] = ticket;
                                }
                                else
                                {
                                    Console.WriteLine("Ce chiffre n'est pas dans la liste !");
                                    i--;
                                }
                            }
                            Console.WriteLine("Voici le ticket choisie :");
                            for (int i = 0; i < tab.Length; i++)
                            {
                                Console.Write(tab[i] + " ");
                            }
                            Console.Write("\n");
                            nbtic--;
                        } while (nbtic != 0);
                        Code();
                    }
                }   /*Fin du tirage de Ticket normal*/
                /*Début historique*/
                else if (réponse == 2)
                {

                }
                /*Fin historique*/
                else if (réponse == 3)
                {

                }
                
            } 
            while (réponse != 4);
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
    }
}