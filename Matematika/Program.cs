using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Matematika
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class Vysledek
    {
        static int vysledekSpravne { get; set; }
        static int vysledekSpatne { get; set; }
                
        public static int Spravne()
        {
            
            vysledekSpravne++;
            return vysledekSpravne;
            
        }

        public static int Spatne()
        {
            vysledekSpatne++;
            return vysledekSpatne;

        }
    }

    public static class GenerujNahodneCislo
    {
        public static int vysledek { get; set; }
        private static int _maxValue; 

        public static int Generuj(int maxValue)
        {
            Random rnd = new Random();
            _maxValue = maxValue;
            vysledek = rnd.Next(_maxValue);
            Thread.Sleep(100);

            return vysledek;
        }
        
    }
       
    
    public enum MatematickaOperace
    {
        Scitani,
        Odecitani,
        Nasobeni,
        Deleni
        
    }

}
