// Built from tag v2.0.10

using System;
using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Felles
{
    public class Person : Aktor
    {
        public enum Relasjonsnavn
        {
            STATSBORGERSKAP,
            KJONN,
            MALFORM,
            PERSONALRESSURS,
            MORSMAL,
            ELEV
        }


        public string Bilde { get; set; }
        public Adresse Bostedsadresse { get; set; }
        public DateTime Fodselsdato { get; set; }
        public Identifikator Fodselsnummer { get; set; }
        public Personnavn Navn { get; set; }
    }
}