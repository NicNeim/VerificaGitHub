using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGit
{
    internal class Libro
    {
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public int AnnoPubblicazione { get; set; }
        public string Editore { get; set; }
        public int Pagine { get; set; }

        public Libro(string autore, string titolo, int annoPubblicazione, string editore, int pagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Editore = editore;
            Pagine = pagine;
        }

        public string toString()
        {
            return "Autore: " + Autore + ", Titolo: " + Titolo + ", Anno di pubblicazione: " + AnnoPubblicazione + ", Editore: " + Editore + ", Pagine: " + Pagine;
        }

        public string readingTime(int p)
        {
            if (p < 100)
            {
                return "1h";
            }
            else
            {
                if (p > 100 && p < 200)
                {
                    return "2h";
                }
                else
                {
                    return "> 2h";
                }
            }
        }
    }
}
