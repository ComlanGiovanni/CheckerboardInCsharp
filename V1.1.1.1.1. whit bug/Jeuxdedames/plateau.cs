using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeuxdedames
{
    class plateau
    {
        int xmax = 10;
        int ymax = 10;
        int nbrpion = 40;
        int nbrjoueur = 2;
        public pion[,] Damier = new pion[10, 10];

        public plateau()
        {
            //pion[,] Damier = new pion[10, 10];
        }

        public void Cr_DAMIER()
        {
            for (int x = 0; x < xmax; x++)
            {
                for (int y = 0; y < ymax; y++)
                Damier[x, y] = null;
            }
        }

        public void Ini_DA2()
        {
            for (int x = 0; x < xmax; x++)
            {
                for (int y = 0; y < ymax; y++)
                {
                    Damier[x, y] = null;
                }
            }

            for (int x = 0; x < xmax; x = x + 2)
            {
                for (int y = 0; y < ymax; y = y + 2)
                {
                    int y1 = y + 1;
                    Damier[0, y] = new pion(false);
                    Damier[1, y1] = new pion(false);
                    Damier[2, y] = new pion(false);
                    Damier[3, y1] = new pion(false);

                    Damier[6, y] = new pion(true);
                    Damier[7, y1] = new pion(true);
                    Damier[8, y] = new pion(true);
                    Damier[9, y1] = new pion(true);
                }
            }
        }

        public void Affiche_DA()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DAME");
            Console.ResetColor();
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("y");
            Console.ResetColor();
            Console.Write("\n");

            for (int x = 0; x < xmax; x++)
            {
                Console.Write("\n");
                for (int y = 0; y < ymax; y++)
                {
                    if (Damier[x, y]==null)
                        Console.Write(" .");
                    else
                        Console.Write(" " + Damier[x, y].CharAffichage);
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   x");
            Console.ResetColor();
        }

        public void Vider_D()
        {
            for (int x = 0; x < xmax; x++)
            {
                for (int y = 0; y < ymax; y++)
                {
                    Damier[x, y] = null;
                }
            }
        }

        public void Deplacement()
        {
            Damier[6, 0] = null;
            Damier[5, 1] = new pion(true);
            /*
            Damier[6, 2] = null;
            Damier[5, 3] = new pion(true);
            */
        }

        public void All_pion()
        {
            int nbr_pionz = 0;
            Console.Write("Emplacement \n");
            for (int x = 0; x < xmax; x++)
            {
                for (int y = 0; y < ymax; y++)
                {
                    if (Damier[x , y] != null)
                    {
                        nbr_pionz = nbr_pionz + 1;
                        Console.Write("(" + x + "," + y + ")\n");
                    }
                }
            }
            Console.Write(" Il y a " + nbr_pionz + " pion \n");
        }

        public void All_pionJ1()
        {
            Console.Write("Emplacement \n");
            int nbr_pionzJ1 = 0;
            for (int x = 0; x < xmax; x++)
            {
                for (int y = 0; y < ymax; y++)
                {
                    if (Damier[x, y] != null && Damier[x, y].Iswhite)
                    {
                        nbr_pionzJ1 = nbr_pionzJ1 + 1;
                        Console.Write("(" + x + "," + y + ")\n");
                    }
                }
            }
            Console.Write("Le joueur 1 a " + nbr_pionzJ1 + " pion \n.");
        }

        public void All_pionJ2()
        {
            Console.Write("Emplacement \n");
            int nbr_pionzJ2 = 0;
            for (int x = 0; x < xmax; x++)
            {
                for (int y = 0; y < ymax; y++)
                {
                    if (Damier[x, y] != null && !Damier[x, y].Iswhite)
                    {
                        nbr_pionzJ2 = nbr_pionzJ2 + 1;
                        Console.Write("(" + x + "," + y + ")\n");
                    }
                }
            }
            Console.Write("Le joueur 2 a " + nbr_pionzJ2 + " pion \n.");
        }


        public void dispo_J1()
                {
                   int nbr_pionz=0;
                    for (int x = 0; x < xmax; x++)
                    {
                        for (int y = 0; y < ymax; y++)
                        {
                            if (Damier[x, y] != null && Damier[x, y].Iswhite)
                            {
                                int x_p = x + 1;
                                int y_p = y + 1;

                                if (x_p > xmax ) 
                                {

                                }
                                if (y_p > ymax)
                                {
                                }


                        /*
                        nbr_pionz = nbr_pionz + 1;
                        Console.Write("(" + x + "," + y + ")\n");
                        if (Damier[x + 1, y + 1] != null)
                        {
                            Console.Write(x + "," + y + " ");
                        }
                        if (Damier[x + 1, y + 1] != null)
                        {
                            Console.Write(x + "," + y + " ");
                        }
                        */
                    }
                        }
                    }
                   Console.Write(nbr_pionz + "\n");
                }

            }
        }
