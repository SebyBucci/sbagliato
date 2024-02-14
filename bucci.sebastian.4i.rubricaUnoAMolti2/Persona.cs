using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucci.sebastian._4i.rubricaUnoAMolti
{
    public class Persona
    {
        internal IEnumerable Contatti;

        public int IdPersona { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Persona() { }

        public Persona(string riga)
        {
            string[] campi = riga.Split(',');


            int id = 0;
            int.TryParse(campi[0], out id);
            IdPersona = id;
            Nome = campi[1];
            Cognome = campi[2];
        }
    }
}
