using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsGame.Klasy
{
    public class Gracz
    {
        public string Nazwa;

        /// <summary>
        /// zestaw wszystich pól gracza
        /// -1 - pole puste
        // 0-3 - pole statku o długosci +1
        /// </summary>
        public int[,] Plansza;

        /// <summary>
        /// pola odkryte w czasie gry
        /// </summary>
        public bool[,] OdkrytePola;

        /// <summary>
        /// Zestaw statków gracza
        /// </summary>
        public int[] Flota;

        public int LiczbaStatkówDoZatopienia;

        public static int ROZMIAR_PLANSZY = 10;
        public static int OSTATNI_INDEX_PLANSZY = ROZMIAR_PLANSZY - 1;

        public Gracz()
        {
            Flota = new int[] { 1, 2, 3, 4 };

            Plansza = new int[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];

            OdkrytePola = new bool[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];

            LiczbaStatkówDoZatopienia = Flota.Length;

            for (int i = 0; i < ROZMIAR_PLANSZY; i++)
            {
                for (int j = 0; j < ROZMIAR_PLANSZY; j++)
                {
                    Plansza[i, j] = -1;

                    OdkrytePola[i, j] = false;
                }
            }
        }

    }
}
