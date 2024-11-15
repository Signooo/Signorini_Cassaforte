﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signorini_Cassaforte
{
    internal class Cassaforte
    {
        private string nMatricola;
        private string produttore;
        private string modello;
        private string codiceSblocco;
        private char stato='C';
        private string codice;
        private int i = 0;
        public string NMatricola
        {
            get { return nMatricola; }
        }
        public string Produttore
        {
            get { return produttore; }
        }
        public string Modello
        {
            get { return modello; }
        }
        public string CodiceSblocco
        {
            get { return codiceSblocco; }
        }
        public Cassaforte(string nMatricola, string produttore, string modello, string codiceSblocco)
        {
            this.nMatricola = nMatricola;
            this.produttore = produttore;
            this.modello = modello;
            this.codiceSblocco = codiceSblocco;
        }
        public void Codice(string nuovoCodice)
        {
            if (nuovoCodice.Length == 5)
            {
                codice = nuovoCodice;
                MessageBox.Show("Nuovo pin creato");
            }
            else
            {
                MessageBox.Show("Inserire 5 numeri");
            }

            }
        public void Apri(string pin)
        {
            
            if(pin.Length == 5)
            {
                if (pin == codice && stato == 'C')
                {
                    stato = 'A';
                    MessageBox.Show("cassaforte aperta");
                }
                else
                    if (pin != codice && stato == 'C' && i < 4)
                    {   
                    MessageBox.Show("Codice errato");
                    i++;
                }
                    else 

                    {
                        MessageBox.Show("I 5 tentativi sono stati superati, inserire il codice di sblocco segreto");
                        stato = 'B';
                    }
            }
            else
            {
                MessageBox.Show("Inserire 5 numeri");
            }
        }
        public void Chiudi()
        {
            stato = 'C';
            MessageBox.Show("cassaforte chiusa");
        }
        public void Sblocca(string codice)
        {
            if (codice.Length == 12)
            {
                if (codice == codiceSblocco && stato == 'B')
                {
                    stato = 'A';
                    MessageBox.Show("cassaforte aperta");
                }
                else
                {
                    MessageBox.Show("Codice di sblocco errato");
                }
            }
            else
            {
                MessageBox.Show("Inserire 5 numeri");
            }
        }

    }
}
