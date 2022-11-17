using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bibliotecaScolastica
{
    //Commento fatto
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        class Libro 
        {
            internal string Autore { get; set; }
            internal string Titolo { get; set; }
            internal string Editore { get; set; }
            internal int AnnoPubblicazione { get; set; }
            internal int NumeroPagine { get; set; }

            internal Libro(string autore, string titolo, string editore, int annoPubblicazione, int numeroPagine)
            {
                this.Autore = autore;
                this.Titolo = titolo;
                this.Editore = editore;
                this.AnnoPubblicazione = annoPubblicazione;
                this.NumeroPagine = numeroPagine;
            }

            public Libro toString(string autore, string titolo, string editore, int annoPubblicazione, int numeroPagine) 
            {
                return new Libro(autore, titolo, editore, annoPubblicazione, numeroPagine);
            }

            public int readingTime(string autore, string titolo, string editore, int annoPubblicazione, int numeroPagine) 
            {
                int tempo = 0;

                if (numeroPagine < 100)
                {
                    tempo = 60;
                }
                else if(numeroPagine > 100 && numeroPagine < 200) 
                {
                    tempo = 120;  
                }
                else if(numeroPagine > 200) 
                {
                    tempo = 180;
                }
                return tempo;
            }
        }
        
        class Biblioteca 
        {
            List<Libro> elencoLibri = new List<Libro>();

            internal string NomeCliente { get; set; }
            internal string Indirizzo { get; set; }
            internal int OrariApertura { get; set; }
            internal int OrariChiusura { get; set; }

            internal Biblioteca(List<Libro> elencoLibri, string nomeCliente, string indirizzo, int orariApertura, int orariChiusura)
            {
                this.elencoLibri = elencoLibri;
                this.NomeCliente = nomeCliente;
                this.Indirizzo = indirizzo;
                this.OrariApertura = orariApertura;
                this.OrariChiusura = orariChiusura;
            }

            public void OperazioniLibro(Libro Autore, Libro titolo, Libro editore, Libro annoPubblicazione, Libro numeroPagine,List<Libro> libri) 
            {
                elencoLibri.Add(Autore);
                elencoLibri.Add(titolo);
                elencoLibri.Add(editore);
                elencoLibri.Add(annoPubblicazione);
                elencoLibri.Add(numeroPagine);


                for (int i = 0; i < elencoLibri.Count; i++)
                {
                    if (elencoLibri.Contains(titolo))
                    {
                        titolo = (Libro)elencoLibri[i]; 
                    }
                }

                for (int j = 0; j < elencoLibri.Count; j++)
                {
                    if (elencoLibri.Contains(Autore))
                    {
                        Autore = (Libro)elencoLibri[j];
                    }
                }

                for (int i = 0; i < elencoLibri.Count; i++)
                {
                    int numeroLibri = 0;
                    numeroLibri = elencoLibri.Count;
                }
            }
        }
    }
}
