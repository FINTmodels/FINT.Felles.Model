// Built from tag v2.6.0-beta-2

using System;
using System.Collections.Generic;



namespace FINT.Model.Felles.Kompleksedatatyper
{
	public class Adresse {
		public enum Relasjonsnavn
        {
			LAND
        }
        
	
		public List<string> Adresselinje { get; set; }
		public string Postnummer { get; set; }
		public string Poststed { get; set; }
		
	}
}
