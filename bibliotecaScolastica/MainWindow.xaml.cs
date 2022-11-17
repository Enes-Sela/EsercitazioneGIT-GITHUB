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
    }
}
