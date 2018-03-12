using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeuxdedames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-> IA 2-> 2 Joueur 0->Exit");
            //Console.ReadKey();

            Console.Write(">>");
            int saisie = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Vous avez saisi : " + saisie);

            switch (saisie)
            {
                case 1:
                    Console.WriteLine("IA indisponible");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Initialisation du plateau.....");
                    //System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    plateau plateau = new plateau();
                    //plateau.Cr_DAMIER();

                    plateau.Ini_DA2();
                    plateau.Affiche_DA();

                    Console.Write("\n");
                    Console.Write("\n");
                    Console.Write("Vous avez 20 piont !\n");
                    Console.Write(">>");
                    int test = Convert.ToInt32(Console.ReadLine());
                    switch (test)
                    {
                        case 0:
                            Console.Clear();
                            plateau.All_pion();
                            plateau.Affiche_DA();
                            break;
                        case 1:
                            Console.Clear();
                            plateau.All_pionJ1();
                            plateau.Affiche_DA();
                            break;
                        case 2:
                            Console.Clear();
                            plateau.All_pionJ2();
                            plateau.Affiche_DA();
                            break;
                        case 3:
                            Console.Clear();
                            plateau.Vider_D();
                            plateau.Affiche_DA();
                            break;

                        case 4:
                            Console.Clear();
                            plateau.dispo_J1();
                            plateau.Affiche_DA();
                            break;

                        default:
                            break;
                    }
                    Console.ReadKey();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
